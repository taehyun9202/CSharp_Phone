using System;
namespace Phone.Models
{
    public abstract class Phone
    {
        protected string _versionNumber;
        protected int _batteryPercentage;
        protected string _carrier;
        protected string _ringTone;

        public abstract bool HasJuice {get;}

        public Phone(string number, int battery, string carrier, string ring)
        {
            _versionNumber = number;
            _batteryPercentage = battery;
            _carrier = carrier;
            _ringTone = ring;
        }
        // abstract method. This method will be implemented by the subclasses
        public abstract void DisplayInfo();
        // public getters and setters removed for brevity. Please implement them yourself
        // public abstract 
        public abstract int Charge();
    }


}