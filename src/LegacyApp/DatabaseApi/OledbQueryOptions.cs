using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace QueryExPlusPlus.WinformsMdiApp
{
    /// <summary>
    /// Defining provider-specific query options that can be globally applied 
    /// to commands and/or connections.
    /// Not yet implemented for OleDB
    /// </summary>
    class OleDbQueryOptions : QueryOptions
    {
        public override void ApplyToConnection(IDbConnection connection)
        {
            return;
        }

        public override void SetupBatch(IDbConnection connection)
        {
            return;
        }

        public override void ResetBatch(IDbConnection connection)
        {
            return;
        }

        public override DialogResult ShowForm()
        {
            return ShowForm(new QueryOptionsForm());
        }
    }
}