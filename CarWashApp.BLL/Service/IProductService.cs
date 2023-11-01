using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWashApp.BLL.Service
{
    public interface IProductService
    {
        bool Add(string productName, int stock, int stockWarningThreshold);
        bool Update(string productName, int stock, int stockWarningThreshold);
    }
}
