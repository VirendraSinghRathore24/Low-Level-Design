public abstract class LogProcessor
{
    public LogProcessor nextLogProcessor;

    public LogProcessor(LogProcessor nextLogProcessor)
    {
        this.nextLogProcessor = nextLogProcessor;
    }

    public virtual void Log(string type, string message)
    {
        if(nextLogProcessor != null)
        {
            nextLogProcessor.Log(type, message);
        }
    }
}