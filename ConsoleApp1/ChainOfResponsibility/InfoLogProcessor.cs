public class InfoLogProcessor : LogProcessor
{
   public InfoLogProcessor(LogProcessor logProcessor) : base(logProcessor)
   {
   }

   public override void Log(string type, string message)
   {
        if(type == "Info")
        {
            Console.WriteLine("Info => " + message);
        }
        else
        {
            base.Log(type, message);
        }
   }
}