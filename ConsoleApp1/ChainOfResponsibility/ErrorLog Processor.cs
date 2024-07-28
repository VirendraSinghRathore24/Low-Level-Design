public class ErrorLogProcessor : LogProcessor
{
    public ErrorLogProcessor(LogProcessor logProcessor) : base(logProcessor)
    {

    }

    public override void Log(string type, string message)
    {
        if(type == "Error")
        {
            Console.WriteLine("Error => " + message);
        }
        else
        {
            base.Log(type, message);
        }
    }
}