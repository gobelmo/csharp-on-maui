using System;

namespace CsharpOnMaui.BusinessLogic;

public class Car
{
    public string Name { get; set; }
    public double Speed { get; set; } //unit per milisecound

    
   
    public Car(string name, double speed)
    {
        Name = name;
        Speed = speed;
    }

    public uint TimeUseForRunWithDistance(double distance)
    {
        //return distance the car can run after xxx minute
       return Convert.ToUInt16(distance / this.Speed) ;
    }

}
