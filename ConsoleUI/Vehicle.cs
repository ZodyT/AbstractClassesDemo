using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    /*
     * Create an abstract class called Vehicle
     * The vehicle class shall have three string properties Year, Make, and Model
     * Set the defaults to something generic in the Vehicle class
     * Vehicle shall have an abstract method called DriveAbstract with no implementation
     * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
     */
    abstract class Vehicle
    {
        public int Year { get; set; } = 0000
        public string Make { get; set; } = "Generic Make"
        public string Model { get; set; } = "Generic Model"
    }
    public abstract void DriveAbstract();

    public virtual void DriveAbstract();
    {
    }


}
