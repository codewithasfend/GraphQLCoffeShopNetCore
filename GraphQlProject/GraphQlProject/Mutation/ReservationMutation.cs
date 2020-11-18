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
    public class ReservationMutation : ObjectGraphType
    {
        public ReservationMutation(IReservation reservationService)
        {

            Field<ReservationType>("createReservation", arguments: new QueryArguments(new QueryArgument<ReservationInputType> { Name = "reservation" }),
             resolve: context =>
             {
                 return reservationService.AddReservation(context.GetArgument<Reservation>("reservation"));
             });

        }
    }
}
