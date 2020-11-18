using GraphQL;
using GraphQL.Types;
using GraphQlProject.Interfaces;
using GraphQlProject.Models;
using GraphQlProject.Type;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQlProject.Mutation
{
    public class MenuMutation : ObjectGraphType
    {
        public MenuMutation(IMenu menuService)
        {

            Field<MenuType>("createMenu", arguments: new QueryArguments(new QueryArgument<MenuInputType> { Name = "menu" }),
             resolve: context =>
             {
                 return menuService.AddMenu(context.GetArgument<Menu>("menu"));
             });

        }
    }
}
