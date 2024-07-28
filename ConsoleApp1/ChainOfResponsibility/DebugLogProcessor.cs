public class DebugLogProcessor : LogProcessor
{
    public DebugLogProcessor(LogProcessor nextLogProcessor) : base(nextLogProcessor)
    {
    }

    public override void Log(string type, string message)
    {
        if(type == "Debug")
        {
            Console.WriteLine("Debug => " + message);
        }
        else
        {
            base.Log(type, message);
        }
    }
}