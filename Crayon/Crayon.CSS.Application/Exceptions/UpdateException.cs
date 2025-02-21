namespace Crayon.CSS.Application.Exceptions;

public class UpdateException : Exception
{
    public string ErrorCode { get; }

    public UpdateException(string errorCode, string message) : base(message)
    {
        ErrorCode = errorCode;
    }
}
