﻿namespace Crayon.CSS.Application.Exceptions;

public class NotFoundException : Exception
{
    public string ErrorCode { get; }

    public NotFoundException(string errorCode, string message) : base(message)
    {
        ErrorCode = errorCode;
    }

}
