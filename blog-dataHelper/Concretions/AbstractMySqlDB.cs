using blog_dataHelper.Abstractions;
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
        public DataSet GetDataSet(string command, Dictionary<string, KeyValuePair<SqlDbType, object>> parameters)
        {
            try
            {
                DataSet ds = new DataSet();
                using (SqlConnection con = new SqlConnection(DBConfigurer.ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand(command, con);
                    cmd.Parameters.AddRange(DictionaryToSqlParameterList(parameters));
                    DataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(ds);
                }
                return ds;
            }
            catch(Exception ex)
            {
                return null;
            }
        }

        private SqlParameter[] DictionaryToSqlParameterList(Dictionary<string, KeyValuePair<SqlDbType, object>> parameters)
        {

            SqlParameter[] sqlParameters = new SqlParameter[parameters.Count];
            int index = 0;
            foreach (var parameter in parameters)
            {
                SqlParameter sqlParameter = new SqlParameter(parameter.Key, parameter.Value.Key);

                //DEBT: I think we do not need this casting, as parameter.Value is itseld of type object
                //if (param.Value.Key.Equals(SqlDbType.Int))
                //{
                //    parameter.Value 
                //}

                sqlParameter.Value = parameter.Value.Value;
                sqlParameters[index++] = sqlParameter;
            }
            return sqlParameters;
        }
    }
}
