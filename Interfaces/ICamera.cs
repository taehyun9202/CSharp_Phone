using System;
namespace Phone.Interfaces
{
    public interface ICamera
    {
        int LensCount {get;set;}
        string Snap();
    }
}