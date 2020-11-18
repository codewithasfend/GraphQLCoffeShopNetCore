using GraphQL.Types;
using GraphQlProject.Interfaces;
using GraphQlProject.Type;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQlProject.Query
{
    public class MenuQuery : ObjectGraphType
    {
        public MenuQuery(IMenu menuService)
        {
            Field<ListGraphType<MenuType>>("menu", resolve: context => { return menuService.GetMenus(); });
        }
    }
}
