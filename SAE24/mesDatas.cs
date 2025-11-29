using System;
using System.Data;
using System.Data.SQLite;

namespace Pinpon
{
    public class MesDatas
    {
        private static DataSet dsGlobal = null;
        public static DataSet DsGlobal
        {
            get
            {
                if (dsGlobal == null)
                {
                    dsGlobal = new DataSet();
                    DataTable schemaTable = Connexion.Connec.GetSchema("Tables");

                    foreach (DataRow ligne in schemaTable.Rows)
                    {
                        string tableName = ligne[2].ToString();
                        string requete = $"SELECT * FROM {tableName}";
                        SQLiteDataAdapter da = new SQLiteDataAdapter(requete, Connexion.Connec);
                        DataTable dtBase = new DataTable
                        {
                            TableName = tableName
                        };
                        da.Fill(dtBase);
                        dsGlobal.Tables.Add(dtBase);
                    }
                }

                return dsGlobal;
            }
        }

        public static DataSet dsDtEngin = new DataSet();
        public static DataSet DsDtEngin
        {
            get
            {
                return dsDtEngin;
            }
            set
            {
                dsDtEngin = value;
            }
        }

        public static DataSet dsDtPompier = new DataSet();
        public static DataSet DsDtPompier
        {
            get
            {
                return dsDtPompier;
            }
            set
            {
                dsDtPompier = value;
            }
        }
    }
}
