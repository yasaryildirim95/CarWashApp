using CarWashApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWashApp.BLL.Service
{
    public interface IWashTypeService
    {
        string AddWashTypeProduct(WashTypeProduct washTypeProduct);
    }
}
