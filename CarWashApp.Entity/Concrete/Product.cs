using CarWashApp.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWashApp.Entity.Concrete
{
    public class Product : IEntity
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int Stock {  get; set; }
        public int StockWarningThreshold { get; set; }

    }
}
