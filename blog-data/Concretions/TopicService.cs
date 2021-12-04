using blog_data.Abstractions;
using blog_dataHelper.Abstractions;
using blog_models.SideNav;
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
BIN_TO_UUID(top_id), top_name, top_top_id, top_cat_id
FROM ct_topic
WHERE top_cat_id = UUID_TO_BIN('@categoryId')";
            Dictionary<string, KeyValuePair<SqlDbType, object>> parameters = new Dictionary<string, KeyValuePair<SqlDbType, object>>
            {
                { "@categoryId", new KeyValuePair<SqlDbType, object>(SqlDbType.UniqueIdentifier, categoryId) }
            };

            var ds = _abstractDB.GetDataSet(sql, parameters);
            if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0)
                return null;

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                Topic topic = new Topic()
                {
                    Id = row.Field<Guid>("top_id"),
                    Name = row.Field<string>("top_name"),
                    ParentTopic = row.Field<Guid>("top_top_id"),
                    CategoryId = row.Field<Guid>("top_cat_id"),
                };
                topics.Add(topic);
            }
            return topics;
        }
    }
}
