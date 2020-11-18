using GraphQlProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQlProject.Interfaces
{
    public interface ISubMenu
    {
        List<SubMenu> GetSubMenus();
        List<SubMenu> GetSubMenus(int menuId);
        SubMenu AddSubMenu(SubMenu subMenu);

    }
}
