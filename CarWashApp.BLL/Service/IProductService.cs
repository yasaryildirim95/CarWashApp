using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWashApp.BLL.Service
{
    public interface IProductService
    {
        string Add(string productName, int stock, int stockWarningThreshold);
        string Update(string productName, int stock, int stockWarningThreshold);
    }
}
