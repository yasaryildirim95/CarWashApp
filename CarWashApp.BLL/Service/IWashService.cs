﻿using CarWashApp.DAL.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWashApp.BLL.Service
{
    public interface IWashService
    {
        string AddWash(string washTypeName, string plate, string dirtinessLevelName);
        List<DataGridStruct> RunCarWash();
    }
}
