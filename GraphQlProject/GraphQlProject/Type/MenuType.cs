using GraphQL;
using GraphQL.Types;
using GraphQlProject.Interfaces;
using GraphQlProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQlProject.Type
{
    public class MenuType : ObjectGraphType<Menu>
    {
        public MenuType(ISubMenu subMenuService)
        {
            Field(m => m.Id);
            Field(m => m.Name);
            Field(m => m.ImageUrl);
            Field<ListGraphType<SubMenuType>>("submenus", resolve: context => { return subMenuService.GetSubMenus(context.Source.Id); });
        }
    }
}
