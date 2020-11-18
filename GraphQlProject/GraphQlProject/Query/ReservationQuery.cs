using GraphQL.Types;
using GraphQlProject.Interfaces;
using GraphQlProject.Type;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQlProject.Query
{
    public class ReservationQuery : ObjectGraphType
    {
        public ReservationQuery(IReservation reservationService)
        {
            Field<ListGraphType<ReservationType>>("reservations", resolve: context => { return reservationService.GetReservations(); });
        }
    }
}
