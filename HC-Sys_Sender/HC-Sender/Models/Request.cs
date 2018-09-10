using Dapper;
using HC_Sender.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCSys.Models
{
    public class Request
    {
        public int Id { get; set; }
        public int QueryTypeid { get; set; }
        public string Description_En { get; set; }
        public string Desciption_Ar { get; set; }
        public string Description_Urdo { get; set; }

        public static List<Request> RefreshDataListe(int ARequestType = 0)
        {
            var FQuery = string.Empty;

            if (ARequestType > 0)
            {
                FQuery = "SELECT * FROM request"
                       + " WHERE RequestTypeid="+ARequestType.ToString();
            }
            else
            {
                FQuery = "SELECT * FROM request";
            }

            return Connexion.db.Query<Request>(FQuery).ToList();
        }
    }
}
