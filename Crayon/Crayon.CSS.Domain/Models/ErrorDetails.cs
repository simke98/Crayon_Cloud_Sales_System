using System.Text.Json;

namespace Crayon.CSS.Domain.Models;

public class ErrorDetails
{
    public int StatusCode { get; set; }
    public string Message { get; set; }
    public string ErrorCode { get; set; }
    public override string ToString()
    {
        return JsonSerializer.Serialize(this);
    }
}
