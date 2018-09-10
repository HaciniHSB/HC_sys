using Dapper;
using HC_Sender.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCSys.Models
{
    public class terminal_request
    {
        public int Id { get; set; }
        public int TerminalId { get; set; }
        public DateTime DateTime { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public int Request_Id { get; set; }

        public static List<terminal_request> RefreshDataListe()
        {
            var FQuery = "SELECT * FROM request";
            return Connexion.db.Query<terminal_request>(FQuery).ToList();
        }

        public static List<dynamic> LoadData()
        {
            var FQuery = @"SELECT tr.id, t.Description,tr.DateTime,rt.Description_En
                            FROM terminal_request tr
                            left join  terminal t on t.Id=tr.TerminalId
                            left join request r on r.Id=tr.Request_Id
                            left join request_type rt on rt.Id=r.RequestTypeid";
            return Connexion.db.Query(FQuery).ToList();
        }
    }
}
