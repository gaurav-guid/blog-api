using blog_models.SideNav;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blog_data.Abstractions
{
    public interface ITopicService
    {
        IEnumerable<Topic> GetAllLinksByCategoryId(Guid categoryId);
    }
}
