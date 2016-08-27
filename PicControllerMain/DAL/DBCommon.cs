using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PicControllerMain.DataBase
{
    public interface IDBCommon
    {
        int Save();
        int Update();

        int Delete();

        IEnumerable<T> Find<T>() where T : class;
    }
}
