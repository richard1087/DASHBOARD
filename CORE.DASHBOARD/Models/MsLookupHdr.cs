using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CORE.DASHBOARD.Models
{
    public class MsLookupHdr
    {
        public string Kode { get; set; }
        public string Keterangan { get; set; }
        public string IBy { get; set; }
        public DateTime? IOn { get; set; }
        public string UBy { get; set; }
        public DateTime? UOn { get; set; }
    }
}
