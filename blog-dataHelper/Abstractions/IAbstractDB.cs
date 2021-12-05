using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blog_dataHelper.Abstractions
{
    public interface IAbstractDB
    {
        DataSet GetDataSet(string command, Dictionary<string, KeyValuePair<MySqlDbType, Object>> parameters);
    }
}
