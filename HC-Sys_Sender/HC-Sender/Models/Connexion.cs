using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Linq;

namespace HC_Sender.Models
{
    class Connexion
    {
        public static MySqlConnection db;
        public static int currUser = 1;

        public static string Host = "10.0.36.161";
        public static string Port = "3306";
        public static string DBName = "hcsys";
        public static string user = "hacini";
        public static string password = "diden1989";

        public static string StringCon =
        @"server =" + Connexion.Host +
            ";port=" + Connexion.Port +
            ";database=" + Connexion.DBName +
            ";uid=" + Connexion.user +
            ";password=" + Connexion.password +
            ";Allow User Variables=True" +
            ";Convert Zero Datetime=True" +
            ";Allow Zero Datetime=True" +
            ";CharSet=utf8" +
            ";SslMode=none";

        public static string StringConEF =
        @"server =" + Connexion.Host +
            ";port=" + Connexion.Port +
            ";database=" + Connexion.DBName +
            ";uid=" + Connexion.user +
            ";password=" + Connexion.password +
            ";Allow User Variables=True" +
            ";Convert Zero Datetime=True" +
            ";Allow Zero Datetime=True" +
            ";CharSet=utf8";



        public static void ConnectToDb()
        {
            db = new MySqlConnection(StringCon);
            if (db.State == ConnectionState.Closed)
            {
                db.Open();
            }
        }


        public static void NInsert(object AObject = null)
        {
            var FType = AObject.GetType(); //typeof(FObject);
            var classAttributes = Attribute.GetCustomAttributes(FType);

            string FAttributes = string.Empty;
            string FValues = string.Empty;


            foreach (var property in FType.GetProperties())
            {
                if (property.Name.ToString().ToUpper() != "ID")
                {
                    FAttributes = FAttributes + property.Name.ToString() + ",";
                    FValues = FValues + " @" + property.Name.ToString() + ",";
                }
            }

            FAttributes = FAttributes.Remove(FAttributes.Length - 1);
            FValues = FValues.Remove(FValues.Length - 1);

            var FQuery = @"INSERT INTO " + AObject.GetType().Name + " (" + FAttributes + ") VALUES (" + FValues + ");";
            Connexion.db.Execute(FQuery, AObject);
        }

        public static void NUpdate(object AObject = null)
        {
            var FType = AObject.GetType();  //typeof(Document);
            var classAttributes = Attribute.GetCustomAttributes(FType);
            var FIdAttribute = string.Empty;
            var FQuery = "UPDATE " + AObject.GetType().Name + " SET ";


            foreach (var property in FType.GetProperties())
            {
                if (property.Name.ToString().ToUpper() != "ID")
                {
                    FQuery = FQuery + property.Name.ToString() + "=@" + property.Name.ToString() + ",";
                }
                else
                {
                    FIdAttribute = property.Name.ToString();
                }
            }

            var FID = AObject.GetType().GetProperty(FIdAttribute).GetValue(AObject, null);
            FQuery = FQuery.Remove(FQuery.Length - 1);
            FQuery = FQuery + " WHERE " + FIdAttribute + "=" + FID.ToString();
            Connexion.db.Execute(FQuery, AObject);
        }


        public static DateTime GetServerDateTime()
        {
            return db.Query<DateTime>("Select NOW()").SingleOrDefault();
        }

        public static int LastInsertedID()
        {
            return db.Query<int>("SELECT LAST_INSERT_ID()").SingleOrDefault();
        }


    }
}
