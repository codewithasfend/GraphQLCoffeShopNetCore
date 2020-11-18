using GraphQlProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQlProject.Interfaces
{
    public interface IMenu
    {
        List<Menu> GetMenus();
        Menu AddMenu(Menu menu);
    }
}
