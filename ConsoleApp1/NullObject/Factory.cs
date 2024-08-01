public class Factory
{
    public static IVehicle GetVehicleObject(string vehicleType)
    {
        if(vehicleType == "Car")
        {
            return new Car();
        }

        return new NullVehicle();
    }
}