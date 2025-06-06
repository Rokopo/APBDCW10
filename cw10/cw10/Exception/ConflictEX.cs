namespace cw10.Exception;

public class ConflictEX : System.Exception
{
    public ConflictEX()
    {
    }

    public ConflictEX(string? message) : base(message)
    {
    }

    public ConflictEX(string? message, System.Exception? innerException) : base(message, innerException)
    {
    }
}