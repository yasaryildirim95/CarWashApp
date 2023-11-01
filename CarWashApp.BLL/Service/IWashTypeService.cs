using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWashApp.BLL.Service
{
    public interface IWashTypeService
    {
        bool Add(string washTypeName, int duration, int price, int usage, params string[] productNames);
    }
}
