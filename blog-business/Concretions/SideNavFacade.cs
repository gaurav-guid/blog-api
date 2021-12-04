using blog_business.Abstractions;
using blog_data.Abstractions;
using blog_models.SideNav;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blog_business.Concretions
{
    public class SideNavFacade : ISideNavFacade
    {
        private readonly ITopicService _topicService;

        public SideNavFacade(ITopicService topicService)
        {
            this._topicService = topicService;
        }
        public IEnumerable<Topic> GetAllLinksByCategoryId(Guid categoryId)
        {
            return _topicService.GetAllLinksByCategoryId(categoryId);
        }
    }
}
