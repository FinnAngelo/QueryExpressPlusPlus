using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Text;

namespace QueryExPlusPlus.LegacyApp
{
    class OleDbClient  : DbClient
    {
        public OleDbClient(ConnectionSettings settings)
            : base(settings)
        {}

        public OleDbConnection Connection
        {
            get { return (OleDbConnection) connection; }
        }

        protected override IDbConnection GetDbConnection()
        {
            OleDbConnection con = new OleDbConnection(GenerateConnectionString());
            con.InfoMessage += new OleDbInfoMessageEventHandler(con_InfoMessage);
            return con;
        }

        void con_InfoMessage(object sender, OleDbInfoMessageEventArgs e)
        {
            OnInfoMessage(sender, new InfoMessageEventArgs(e.Message, ""));
        }

        protected override string GenerateConnectionString()
        {
            OleDbConnectionStringBuilder csb = new OleDbConnectionStringBuilder();
            csb.ConnectionString = conSettings.OleDbConnectionString;
            
            return csb.ConnectionString; // connectString.ToString();
        }

        protected override IDbCommand GetDbCommand(string query)
        {
            OleDbCommand cmd = ((OleDbConnection)connection).CreateCommand();
            cmd.CommandText = query;
            return cmd;
        }

        public override QueryOptions GetDefaultOptions()
        {
            return new OleDbQueryOptions();
        }

        protected override IDbDataAdapter GetDataAdapter(IDbCommand command)
        {
            return new OleDbDataAdapter((OleDbCommand) command);
        }

        public override void ApplyQueryOptions()
        {
            return;
/*
            StringBuilder sb = new StringBuilder();
            SqlQueryOptons sqo = ((SqlQueryOptons) queryOptions);
            sb.Append(string.Format(" SET ROWCOUNT {0}", sqo.RowCount));
            sb.Append(string.Format(" SET TEXTSIZE {0}", sqo.TextSize));
            sb.Append(string.Format(" SET NOCOUNT {0}", sqo.NoCount ? "ON" : "OFF"));
            sb.Append(string.Format(" SET CONCAT_NULL_YIELDS_NULL {0}", sqo.Concat_Null_Yields_Null ? "ON" : "OFF"));
            sb.Append(string.Format(" SET ARITHABORT {0}", sqo.ArithAbort ? "ON" : "OFF"));
            sb.Append(string.Format(" SET LOCK_TIMEOUT {0}", sqo.Lock_Timeout));
            sb.Append(string.Format(" SET QUERY_GOVERNOR_COST_LIMIT {0}", sqo.Query_Governor_Cost_Limit));
            sb.Append(string.Format(" SET DEADLOCK_PRIORITY {0}", sqo.Deadlock_Priority));
            sb.Append(string.Format(" SET TRANSACTION ISOLATION LEVEL {0}", sqo.Transaction_Isolation_Level));
            sb.Append(string.Format(" SET ANSI_NULLS {0}", sqo.Ansi_Nulls ? "ON" : "OFF"));
            sb.Append(string.Format(" SET ANSI_NULL_DFLT_ON {0}", sqo.Ansi_Null_Dflt_On ? "ON" : "OFF"));
            sb.Append(string.Format(" SET ANSI_PADDING {0}", sqo.Ansi_Padding ? "ON" : "OFF"));
            sb.Append(string.Format(" SET ANSI_WARNINGS {0}", sqo.Ansi_Warnings ? "ON" : "OFF"));
            sb.Append(string.Format(" SET CURSOR_CLOSE_ON_COMMIT {0}", sqo.Cursor_Close_On_Commit ? "ON" : "OFF"));
            sb.Append(string.Format(" SET IMPLICIT_TRANSACTIONS {0}", sqo.Implicit_Transactions ? "ON" : "OFF"));
            sb.Append(string.Format(" SET QUOTED_IDENTIFIER {0}", sqo.Quoted_Identifier ? "ON" : "OFF"));

            ExecuteOnWorker(sb.ToString(), 5);
*/
        }

    }
}
