using blog_models.SideNav;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blog_business.Abstractions
{
    public interface ISideNavFacade
    {
        //DEBT: Add sort order to side nav links.
        IEnumerable<Topic> GetAllLinksByCategoryId(Guid categoryId);
    }
}
