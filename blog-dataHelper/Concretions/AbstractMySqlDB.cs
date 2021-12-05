using blog_dataHelper.Abstractions;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blog_dataHelper.Concretions
{
    public class AbstractMySqlDB : IAbstractDB
    {
        //DEBT: BLOCKER: the way we are currently establishing connection with DB is for MS SQL. It does not work with MySQL.
        public DataSet GetDataSet(string command, Dictionary<string, KeyValuePair<MySqlDbType, object>> parameters)
        {
            try
            {
                DataSet ds = new DataSet();
                using (var con = new MySqlConnection(DBConfigurer.ConnectionString))
                {
                    var cmd = new MySqlCommand(command, con);
                    cmd.Parameters.AddRange(DictionaryToSqlParameterList(parameters));
                    DataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(ds);
                }
                return ds;
            }
            catch(Exception ex)
            {
                return null;
            }
        }

        private MySqlParameter[] DictionaryToSqlParameterList(Dictionary<string, KeyValuePair<MySqlDbType, object>> parameters)
        {

            MySqlParameter[] mySqlParameters = new MySqlParameter[parameters.Count];
            int index = 0;
            foreach (var parameter in parameters)
            {
                MySqlParameter mySqlParameter = new MySqlParameter(parameter.Key, parameter.Value.Key);

                //DEBT: I think we do not need this casting, as parameter.Value is itseld of type object
                //if (param.Value.Key.Equals(MySqlDbType.Int))
                //{
                //    parameter.Value 
                //}

                mySqlParameter.Value = parameter.Value.Value;
                mySqlParameters[index++] = mySqlParameter;
            }
            return mySqlParameters;
        }
    }
}
