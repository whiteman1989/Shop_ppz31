﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Shop_PPZ_31
{
    class Employee
    {
        private static int count = 1;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Position { get; set; }
        public int ChiefId { get; set; }
        public Employee(string Name, string Surname, string Position, int ChiefId)
        {
            this.Id = count++;
            this.Name = Name;
            this.Surname = Surname;
            this.Position = Position;
            this.ChiefId = ChiefId;
        }
        public override string ToString()
        {
            return string.Format($"{Id} {Name} {Surname} {Position} {ChiefId}");
        }
    }
}
