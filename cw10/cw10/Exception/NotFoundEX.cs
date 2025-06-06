namespace cw10.Exception;

public class NotFoundEX : System.Exception
{
    public NotFoundEX()
    {
    }
    
    public NotFoundEX(string? message) : base(message)
    {
    }
    
    public NotFoundEX(string? message, System.Exception? innerException) : base(message, innerException)
    {
    }
}