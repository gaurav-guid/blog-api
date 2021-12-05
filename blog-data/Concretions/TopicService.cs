using blog_data.Abstractions;
using blog_dataHelper.Abstractions;
using blog_models.SideNav;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blog_data.Concretions
{
    public class TopicService : ITopicService
    {
        private readonly IAbstractDB _abstractDB;
        public TopicService(IAbstractDB abstractDB)
        {
            this._abstractDB = abstractDB;
        }
        public IEnumerable<Topic> GetAllLinksByCategoryId(Guid categoryId)
        {
            List<Topic> topics = new List<Topic>();
            string sql = @"
SELECT
BIN_TO_UUID(top_id) AS top_id, top_name, BIN_TO_UUID(top_top_id) AS top_top_id, BIN_TO_UUID(top_cat_id) AS top_cat_id
FROM ct_topic
WHERE top_cat_id = UUID_TO_BIN(@categoryId)";
            Dictionary<string, KeyValuePair<MySqlDbType, object>> parameters = new Dictionary<string, KeyValuePair<MySqlDbType, object>>
            {
                { "@categoryId", new KeyValuePair<MySqlDbType, object>(MySqlDbType.Guid, categoryId) }
            };

            var ds = _abstractDB.GetDataSet(sql, parameters);
            if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0)
                return null;

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                Guid parsedParentTopic = Guid.Empty;
                Guid parsedCategoryId = Guid.Empty;
                Topic topic = new Topic()
                {
                    Id = Guid.Parse(row.Field<string>("top_id")),
                    Name = row.Field<string>("top_name"),
                    ParentTopic = Guid.TryParse(row.Field<string>("top_top_id"), out parsedParentTopic) ? parsedParentTopic : parsedParentTopic,
                    CategoryId = Guid.TryParse(row.Field<string>("top_cat_id"), out parsedCategoryId) ? parsedCategoryId : parsedCategoryId,
                };
                topics.Add(topic);
            }
            return topics;
        }
    }
}
