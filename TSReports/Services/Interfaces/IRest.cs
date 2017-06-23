using System;
using System.Collections.Generic;

namespace TSReports.Services
{
    interface IRest
    {
        IList<T> List<T>();
        Object Get();
        int Update();
        int Save();
        bool Delete(int id);
    }
}
