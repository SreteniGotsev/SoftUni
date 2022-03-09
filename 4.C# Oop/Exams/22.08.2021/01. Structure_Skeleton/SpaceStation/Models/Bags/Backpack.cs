using System;
using System.Collections.Generic;
using System.Text;
using SpaceStation.Models.Bags.Contracts;

namespace SpaceStation.Models.Bags
{
    public class Backpack : IBag
    {
        public Backpack()
        {
            items = new List<string>();
        }

        private List<string> items;

        public ICollection<string> Items { get=>this.items; }
    }
}
