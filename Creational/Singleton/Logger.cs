namespace Singleton;

public class Logger
{
    public string LogFile { get; private set; }
    public static Logger? Instance { get; private set; }

    private Logger()
    {
        LogFile = "arquivo.log";
    }

    public static Logger GetInstance()
    {
        Instance ??= new Logger();
        return Instance;
    }

    public void Log(string message)
    {
        //registra a mensagem em um arquivo de log
    }
}
