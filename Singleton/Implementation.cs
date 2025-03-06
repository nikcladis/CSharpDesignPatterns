namespace Singleton
{
    /// <summary>
    /// Singleton
    /// </summary>
  
  public sealed class Logger
  {
    // With Lazy<T>
    private static readonly Lazy<Logger> _lazyLogger 
        = new Lazy<Logger>(() => new Logger());

    // Without Lazy Initialization

    // private static Logger? _instance;

    /// <summary>
    /// Instance
    /// </summary>
    
    public static Logger Instance
    {
        get
        {
            return _lazyLogger.Value;

            // Without Lazy Initialization

            // if (_instance == null)
            // {
            //     _instance = new Logger();
            // }
            // return _instance;
        }
    }
     
    private Logger() {}

    /// <summary>
    /// SingletonOperation
    /// </summary>

    public void Log(string message)
    {
        Console.WriteLine($"Message to log: {message}");
    }
  }
}
