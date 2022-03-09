using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    public class Cargo
    {
        public Cargo(int cargoWeigth, string cargoType)
        {
            this.CargoWeight = cargoWeigth;
            this.CargpType = cargoType;
        }

        public int CargoWeight { get; set; }
        public string CargpType { get; set; }
    }
}
