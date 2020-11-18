using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQlProject.Type
{
    public class ReservationInputType : InputObjectGraphType
    {
        public ReservationInputType()
        {
            Field<IntGraphType>("id");
            Field<StringGraphType>("name");
            Field<StringGraphType>("phone");
            Field<IntGraphType>("totalPeople");
            Field<StringGraphType>("email");
            Field<StringGraphType>("date");
            Field<StringGraphType>("time");
        }
    }
}
