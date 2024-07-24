namespace TrainingSolidPrinciples.SRP.Solution;

public interface ILogger
{
    void Info(string message);
    void Warn(string message);
    void Error(string message);
}
public class Logger : ILogger
{
    private const string fileName = @"C:\Temp\ErrorLog.txt";

    public void Error(string message)
    {
        File.WriteAllText(fileName, $"[ERROR] {message}");
    }

    public void Info(string message)
    {
        File.WriteAllText(fileName, $"[INFO] {message}");
    }

    public void Warn(string message)
    {
        File.WriteAllText(fileName, $"[WARN] {message}");
    }
}
