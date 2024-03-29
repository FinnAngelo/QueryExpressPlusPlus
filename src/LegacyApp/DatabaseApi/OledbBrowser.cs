using System;
using System.Collections.Specialized;
using System.Data;
using System.Data.OleDb;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace QueryExPlusPlus.LegacyApp
{
    /// <summary>
    /// QueryExpress.dl3bak.OleDbBrowser 
    /// 
    /// An implementation of IBrowser for OleDb
    /// 
    /// (c) 2003 by dl3bak@qsl.net
    /// 
    /// free for public distribution
    /// 
    /// </summary>
    internal class OleDbBrowser : IBrowser
    {
        DbClient dbClient;

        class OleDbNode : TreeNode
        {
            internal int type = -1;
            internal string dragText
            {
                get
                {
                    // if name contains blanks, suround it with []
                    if (Text.IndexOf(' ') >= 0)
                        return "[" + Text + "]";
                    else
                        return Text;

                }
            }
            public OleDbNode(string text, int type)
                : base(text)
            {
                this.type = type;
            }
        }

        public OleDbBrowser(DbClient dbClient)
        {
            this.dbClient = dbClient;
        }

        public DbClient DbClient
        {
            get { return dbClient; }
        }

        public IBrowser Clone(DbClient newDbClient)
        {
            OleDbBrowser sb = new OleDbBrowser(newDbClient);
            return sb;
        }

        public TreeNode[] GetObjectHierarchy()
        {
            TreeNode[] top = new TreeNode[]
			{
				new TreeNode ("TABLE"),				// 0
				new TreeNode ("VIEW"),				// 1
				new TreeNode ("SYSTEM TABLE"),		// 2
				new TreeNode ("SYSTEM VIEW")		// 3
			};

            int curNoteType = 0;
            foreach (TreeNode node in top)
                CreateNodeHierachy(top, curNoteType++, node.Text);

            return top;
        }

        /// <summary>
        /// 
        ///  return TreeNode[].Add("SELECT [COLUMN_NAME] FROM [Columns] WHERE [Tablename] = {filter}")
        /// 
        /// </summary>
        public TreeNode[] GetSubObjectHierarchy(TreeNode node)
        {
            // Show the column breakdown for the selected table

            if (node is OleDbNode)
            {
                string table = node.Text;


                string[] fields = GetOleDbBrowserValues("COLUMN_NAME"
                                        , OleDbSchemaGuid.Columns
                                        , new object[] { GetDatabaseFilter(), null, table });

                if (fields != null)
                {
                    TreeNode[] tn = new OleDbNode[fields.Length];
                    int count = 0;

                    foreach (string name in fields)
                    {
                        OleDbNode column = new OleDbNode(name, -1);
                        tn[count++] = column;
                    }
                    return tn;
                }
            }
            return null;
        }

        public string GetDragText(TreeNode node)
        {
            if (node is OleDbNode)
                return ((OleDbNode)node).dragText;
            else
                return "";
        }

        public StringCollection GetActionList(TreeNode node)
        {
            if (!(node is OleDbNode)) return null;

            OleDbNode on = (OleDbNode)node;
            StringCollection output = new StringCollection();

            if (on.type >= 0)
            {
                output.Add("select * from " + on.dragText);
                output.Add("(insert all fields)");
                output.Add("(insert all fields, table prefixed)");
            }

            return output.Count == 0 ? null : output;
        }

        public string GetActionText(TreeNode node, string action)
        {
            if (!(node is OleDbNode)) return null;

            OleDbNode on = (OleDbNode)node;
            if (action.StartsWith("select * from "))
                return action;

            if (action.StartsWith("(insert all fields"))
            {
                StringBuilder sb = new StringBuilder();
                // If the table-prefixed option has been selected, add the table name to all the fields
                string prefix = action == "(insert all fields)" ? "" : on.dragText + ".";
                int chars = 0;
                foreach (TreeNode subNode in GetSubObjectHierarchy(node))
                {
                    if (chars > 50)
                    {
                        chars = 0;
                        sb.Append("\r\n");
                    }
                    string s = (sb.Length == 0 ? "" : ", ") + prefix + ((OleDbNode)subNode).dragText;
                    chars += s.Length;
                    sb.Append(s);
                }
                return sb.Length == 0 ? null : sb.ToString();
            }

            return null;
        }

        public string[] GetDatabases()
        {
            string[] result = GetOleDbBrowserValues(
                                    "CATALOG_NAME", OleDbSchemaGuid.Catalogs, null);

            if (result == null)
                result = new String[] { dbClient.Database };

            return result;
        }

        public static string GetConnectString(string dbfileName)
        {
            if (!System.IO.File.Exists(dbfileName))
                return null;

            string lowerDbFileName = dbfileName.ToLower();

            if (lowerDbFileName.EndsWith(".connectstring"))
                return getConnectStringFromFileContent(dbfileName);
            else if (lowerDbFileName.EndsWith(".udl"))
                return getConnectStringFromFileContent(dbfileName);
            else if (lowerDbFileName.LastIndexOf('.') > 0)
                return getConnectStringForDatabaseFile(dbfileName);

            return null;
        }

        // Opens databasefile through oledb
        //
        // Example: HandleCmdLineParameterOpenDbFile("Northwind.mdb")
        //		The file "QExpress.mdb.ConnectTemplate" contains a string.Format
        //			for the OleDbConnectString with {0} as placeholder for
        //			the filename
        private static string getConnectStringForDatabaseFile(string dbfileName)
        {
            int fileTypPos = dbfileName.LastIndexOf('.') + 1;
            string templateFileName = "QExpress." + dbfileName.Substring(fileTypPos)
                                        + ".ConnectTemplate";

            string connectTemplate;

            // Load Template from working or exe-directory
            if ((FileUtil.ReadFromFile(Path.Combine(
                                            Directory.GetCurrentDirectory(),
                                            templateFileName)
                                    , out connectTemplate))
                || (FileUtil.ReadFromFile(Path.Combine(
                                            GetExecPath(),
                                            templateFileName)
                                    , out connectTemplate)))
            {
                return string.Format(connectTemplate, dbfileName);
            }
            else
            {
                string msg = string.Format("OleDb-ConnectTemplate-file \"{0}\" not found.\n\n"
                                    + "It contains Information for opening Databasefile \"{1}\"",
                                templateFileName, dbfileName);
                System.Windows.Forms.MessageBox.Show(msg);
            }
            return null;
        }

        // Opens database through udl or connect file
        // reads *.connect; *.udl and *.dsn
        /*	; *.dsn = Microsofts ODBC-File Format
            [ODBC]
            DRIVER=Driver do Microsoft Access (*.mdb)
            FIL=MS Access
            DBQ=D:\Eigene Dateien\Eigene Datenbanken\Northwind.mdb

            ; *.udl = Microsofts OleDB-File Format
            [oledb]
            ; Everything after this line is an OLE DB initstring
            Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Eigene Dateien\Eigene Datenbanken\Northwind.mdb;Persist Security Info=False

            ; *.connect = QueryExpress specific Connect format
            Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Eigene Dateien\Eigene Datenbanken\Northwind.mdb;Persist Security Info=False
			
         */
        public static string getConnectStringFromFileContent(string dbfileName)
        {
            string result = string.Empty;
            string fileContent;
            if (FileUtil.ReadFromFile(Path.Combine(
                                            Directory.GetCurrentDirectory(),
                                            dbfileName)
                                            , out fileContent))
            {
                string[] lines = fileContent.Split('\n', '\r');
                foreach (string line in lines)
                {
                    if ((line.Trim() != string.Empty)
                        && (!line.Trim().StartsWith(";"))
                        && (!line.Trim().StartsWith("[")))
                    {
                        if (result != string.Empty)
                            result += ";";
                        result += line;
                    }
                }

            }
            else
            {
                System.Windows.Forms.MessageBox.Show(FileUtil.Error, dbfileName);
            }

            return result;
        }

        private static string GetExecPath()
        {
            return System.IO.Path.GetDirectoryName(
                System.Reflection.Assembly.GetExecutingAssembly()
                                                        .Location);
        }



        #region implementation helpers

        private string GetDatabaseFilter()
        {
            string result = dbClient.Database;
            if ((result != null) && (result.Length == 0))
                return null;
            return result;
        }

        /// <summary>
        /// top[curNoteType].Add("SELECT [TABLE_NAME] FROM [Tables] WHERE [Tabletyp] = {filter}")
        /// </summary>
        private void CreateNodeHierachy(TreeNode[] top, int curNoteType, string filter)
        {
            string[] result = null;

            result = GetOleDbBrowserValues(
                                    "TABLE_NAME", OleDbSchemaGuid.Tables
                                    , new object[] { GetDatabaseFilter(), null, null, filter });

            if (result != null)
            {
                foreach (string str in result)
                {
                    OleDbNode node = new OleDbNode(str, curNoteType);

                    top[curNoteType].Nodes.Add(node);
                    // Add a dummy sub-node to user tables and views so they'll have a clickable expand sign
                    // allowing us to have GetSubObjectHierarchy called so the user can view the columns
                    node.Nodes.Add(new TreeNode());
                }
            }
        }

        /// <summary>
        /// OleDB specific internal Query
        /// 
        /// SELECT {resultColumnName} 
        /// FROM {schema} 
        /// WHERE {restrictions}
        /// 
        /// </summary>		
        /// <returns>String-Array with Fields from </returns>
        string[] GetOleDbBrowserValues(string resultColumnName
                                        , Guid schema
                                        , object[] restrictions)
        {
            OleDbConnection con = null;
            DataTable tab = null;
            string[] sa = null;

            try
            {
                con = ((OleDbClient)DbClient).Connection;
                tab = con.GetOleDbSchemaTable(schema // ie OleDbSchemaGuid.Columns or .Tables
                                                           , restrictions // ie new object[] {null, null, null, "TABLE"}
                                                           );

                DataColumn col = tab.Columns[resultColumnName]; // ["TABLE_TYPE"];

                sa = new string[tab.Rows.Count];
                int count = 0;
                foreach (DataRow row in tab.Rows)
                    sa[count++] = row[col].ToString().Trim();

            }
            catch (Exception)
            {
            }
            finally
            {
                if (tab != null)
                    tab.Dispose();
            }
            return sa;
        }
        #endregion
    }
}
