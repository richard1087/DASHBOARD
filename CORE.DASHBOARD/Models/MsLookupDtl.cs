using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CORE.DASHBOARD.Models
{
    public class MsLookupDtl
    {
        public string Kode { get; set; }
        public string KodeLookup { get; set; }
        public int NoUrut { get; set; }
        public string NilaiLookup { get; set; }
        public string NilaiLookup2 { get; set; }
        public string NilaiLookup3 { get; set; }
        public string NilaiLookup4 { get; set; }
        public string DisplayLookup { get; set; }
        public string IBy { get; set; }
        public DateTime? IOn { get; set; }
        public string UBy { get; set; }
        public DateTime? UOn { get; set; }
    }
}
