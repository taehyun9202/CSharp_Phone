using System;
using Phone.Interfaces; 
namespace Phone.Models
{
    public class IPhone : Phone, IRingable, ICamera
    {
        public int LensCount {get;set;}
        public int BatteryPercentage 
        {
            get{
                return _batteryPercentage;
            }
        }
        public IPhone(string number, int battery, string carrier, string ring) : base(number, battery, carrier, ring)
        {
            LensCount = 4;
        }
        public override void DisplayInfo()
        {

        }
        public override int Charge()
        {
            if(_batteryPercentage < 100)
            {
                _batteryPercentage += 10;
                Console.WriteLine($"{_batteryPercentage}% Charging...");
                return _batteryPercentage;
            }
            else
            {
                Console.WriteLine("Battery is fully charged now");
                return _batteryPercentage;
            } 
        }

        public override bool HasJuice
        {
            get
            {
                if(_batteryPercentage >= 20)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public string Ring()
        {
            if(HasJuice)
            {
                _batteryPercentage -= 10;
                return _ringTone;
            }
            else
            {
                _batteryPercentage -= 5;
                return "Please Charge your Phone.";
            }
        }

        public string Unlock()
        {
            return "Slide to Unlock!";
        }

        public string Snap()
        {
            return "Nice Selfie!";
        }
    }
}