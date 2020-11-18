using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQlProject.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public int TotalPeople { get; set; }
        public string Email { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }    

    }
}
