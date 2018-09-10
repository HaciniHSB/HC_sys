using Dapper;
using HC_Sender.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCSys.Models
{
    public class Terminal
    {
        public int Id { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public string Description { get; set; }
        public string Message { get; set; }
        public bool Is_Locked { get; set; }
        public string MacAdress { get; set; }
        public string Ip_adress { get; set; }


        public static List<Terminal> RefreshDataListe()
        {
            var FQuery = "SELECT * FROM terminal";
            return Connexion.db.Query<Terminal>(FQuery).ToList();
        }

        public static string RefreshTerminalMsg()
        {
            var FQuery = "SELECT Message FROM terminal "
                        + " WHERE Id=@Id";
            var FRes = Connexion.db.QueryFirstOrDefault(FQuery,new {Id=1});
            return FRes.Message;
        }
    }
}
