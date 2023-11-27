using System;
using System.Collections.Generic;
using Bogus;

// Abstract class for parking garage
abstract class ParkingGarage
{
    public string Name { get; }

    protected ParkingGarage(string name)
    {
        Name = name;
    }

    // Abstract method to calculate charges
    public abstract double CalculateCharges(double hoursParked);
}


