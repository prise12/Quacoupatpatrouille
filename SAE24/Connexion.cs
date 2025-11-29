using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pinpon
{

    internal class Connexion
    {
        private static SQLiteConnection connec;

        private Connexion() { }

        public static SQLiteConnection Connec
        {
            get
            {

                if (connec == null)
                {
                    try
                    {
                        string chaine = @"Data Source = SDIS67TEST.db";
                        connec = new SQLiteConnection(chaine);
                        connec.Open();
                    }
                    catch (SQLiteException err)
                    {
                        Console.WriteLine($"Erreur lors de l'ouverture de la connexion : {err.Message}");
                    }
                }
                return connec;
            }
        }

        public static void FermerConnexion()
        {
            if (connec != null)
            {
                try
                {
                    connec.Close();
                    connec.Dispose();
                    connec = null; 
                }
                catch (Exception err)
                {
                    Console.WriteLine($"Erreur lors de la fermeture de la connexion : {err.Message}");
                }
            }
        }
    }
}
