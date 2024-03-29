﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class Vehicle
    {
        private const double DefaultFuelConsumption = 1.25;
        public int HorsePower { get; set; }
        public double Fuel { get; set; }

        public Vehicle(int horsePower,double fuel)
        {
            this.HorsePower = horsePower;
            this.Fuel = fuel;
        }

        public virtual double FuelConsumpiton => DefaultFuelConsumption;
        public virtual void Drive(double kilometers)
        {
            this.Fuel -= FuelConsumpiton * kilometers;
        }

    }
}
