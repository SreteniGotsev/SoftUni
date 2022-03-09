using System;
using System.Collections.Generic;
using System.Text;

namespace _1.GenericBoxofString
{
    public class Box<T>
    {
        public Box(T value)
        {
            this.Name = value;
            
        }

        public T Name { get; set; }

      
        public override string ToString()
        {
            return $"{this.Name.GetType().FullName}: {this.Name}";
        }
    }
}
