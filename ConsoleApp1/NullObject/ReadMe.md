Design Null Object Pattern

How to avoid null checks

IVehicle vehicle = Factory.GetVehicleObject('Car');
var capacity = vehicle.GetCapacity();

if vehicle is null then it will through null pointer exception.

How can we handle this -> 

IVehicle vehicle = Factory.GetVehicleObject('Car');

if(vehicle != null)
{
    var capacity = vehicle.GetCapacity();
}

It looks good but in case of big projects, we have to add null check many places, which is not good.

We can use Null Object class to avoid this:
    -> A null object replaces NULL return type.
    -> No need to put IF Check for checking null.
    -> Null object reflects do Nothing or Default behavior.