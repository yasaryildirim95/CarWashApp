using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWashApp.DAL.Common
{
    public struct PersonelAvailabilityStruct
    {
        public int PERSONEL_ID {  get; set; }
        public string PERSONEL_ADI { get; set; }
        public string PERSONEL_UYGUNLUGU { get; set; }
        public string ÇALIŞTIGI_ARAC { get; set; }
        public string UYGUN_OLMASINA_KALAN_SURE { get; set; }
    }
}
