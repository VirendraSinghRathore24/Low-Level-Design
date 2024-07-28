/*  
    Basic Requirements:

    1. Multilevel parking lot
    2. Available parking space should be closest to the exit.
    3. Bus, Car, Bike parking
    4. There should be display for parking space
*/
 

 /* 
    Entities:

    1. Spot
    2. Floor
    3. ParkingLot
    4. Display
    5. Ticket
    6. Vehicle
    7. SpotType
  */

using System.Collections.Generic;

  class Spot 
  {
    int spotNumber;
    SpotType spotType;
    bool isAvailable;

    public Spot(int spotNumber, SpotType spotType)
    {
        this.spotNumber = spotNumber;
        this.spotType = spotType;
        this.isAvailable = false;
    }
  }

  class Floor 
  {
    int floorNumber;

    PriorityQueue<Spot, int> smallSpots;
    PriorityQueue<Spot, int> mediumSpots;
    PriorityQueue<Spot, int> largeSpots;

    public Floor(int floorNumber)
    {
        this.floorNumber = floorNumber;

        smallSpots = new PriorityQueue<Spot, int>();
        mediumSpots = new PriorityQueue<Spot, int>();
        largeSpots = new PriorityQueue<Spot, int>(); 
    }

    // Add Floor

    // Remove Floor

    public void AddSpot(Vehicle vehicle)
    {
        // check which vehicle => car
        if(vehicle.vehicleType == VehicleType.CAR)
        {
            // Search empty space for car
            if(mediumSpots.Count == 0) return;

            var spot = mediumSpots.Pop();
        }
    }
    
  }

class Vehicle 
{

    public VehicleType vehicleType; 
    public Vehicle()
    {

    }
}

enum VehicleType
{
    BUS,
    CAR,
    BIKE
}

  enum SpotType
  {
    SMALL,
    MEDIUM,
    LARGE
  }