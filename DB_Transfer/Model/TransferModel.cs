using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Transfer.Model
{
    public class TransferModel
    {
        public string ID { get; set; }
        public int UmfragenID { get; set; }
        public string Frage { get; set; }
        public string Antwort { get; set; }
        public string Typ { get; set; }

        public DateTime Datum { get; set; }
        public string Zielgruppe { get; set; }
    }
}
