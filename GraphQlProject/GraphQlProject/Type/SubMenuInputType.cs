using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQlProject.Type
{
    public class SubMenuInputType : InputObjectGraphType
    {
        public SubMenuInputType()
        {
            Field<IntGraphType>("id");
            Field<StringGraphType>("name");
            Field<StringGraphType>("imageUrl");
            Field<StringGraphType>("description");
            Field<FloatGraphType>("price");
            Field<IntGraphType>("menuId");
        }
    }
}
