using Dapper;
using HC_Sender.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCSys.Models
{
    public class Request_type
    {
        public int Id { get; set; }
        public string Description_En { get; set; }
        public string Desciption_Ar { get; set; }
        public string Description_Urdo { get; set; }



        public static List<Request_type> RefreshDataListe()
        {
            var FQuery = "SELECT * FROM request_type "
                       + " WHERE Is_actif=@Is_actif";
            
            return Connexion.db.Query<Request_type>(FQuery, new { Is_actif = true }).ToList();
        }



    }


}
