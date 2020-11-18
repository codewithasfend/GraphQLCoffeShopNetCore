using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQlProject.Query
{
    public class RootQuery : ObjectGraphType
    {
        public RootQuery()
        {
            Field<MenuQuery>("menuQuery", resolve: context => new { });
            Field<SubMenuQuery>("submenuQuery", resolve: context => new { });
            Field<ReservationQuery>("reservationQuery", resolve: context => new { });
        }
    }
}
