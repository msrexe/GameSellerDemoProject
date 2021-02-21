using GameSellerDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSellerDemo.Entities
{
    public class Gamer
    {
        public int GamerID { get; set; }
        public long NationalID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int DateOfBirth { get; set; }

    }
}
