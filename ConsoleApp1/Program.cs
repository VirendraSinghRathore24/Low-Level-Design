// See https://aka.ms/new-console-template for more information

// TODO : Design Logging System - Chain of Responsibility

LogProcessor logProcessor = new InfoLogProcessor(new DebugLogProcessor(new ErrorLogProcessor(null)));

// logProcessor.Log("Error", "This is error message");
// logProcessor.Log("Info", "This is info");
// logProcessor.Log("Debug", "debugging");


// TODO : Tic Tac Toe 

// Game game = new Game();
// string winner = game.StartGame();
// Console.WriteLine("Winner is " + winner);

// TODO : Parking Lot

// TODO : Snake and Ladder
// Game1 game = new Game1(36);
// game.StartGame();

// TODO : Null design pattern
IVehicle vehicle = Factory.GetVehicleObject("Bike");
int capacity = vehicle.GetCapacity();
Console.WriteLine(capacity);