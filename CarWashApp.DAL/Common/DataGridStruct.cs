using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWashApp.DAL.Common
{
    public class DataGridStruct
    {
        public int SIRA { get; set; }
        public string PLAKA { get; set; }
        public string MARKA { get; set; }
        public string MODEL { get; set; }
        public string YIKAMA_TİPİ { get; set; }
        public string YIKAMA_DURUMU { get; set; }
        public int KALAN_SÜRE { get; set; }
        public string ÇALIŞAN_KİŞİ { get; set; }
    }
}
