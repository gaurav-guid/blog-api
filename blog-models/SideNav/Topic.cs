using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blog_models.SideNav
{
    public class Topic
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid ParentTopic { get; set; }
        public Guid CategoryId { get; set; }
    }
}
