﻿namespace Crayon.CSS.Application.Exceptions
{
    public class ValidationException : Exception
    {
        public string ErrorCode { get; }

        public ValidationException(string errorCode, string message) : base(message)
        {
            ErrorCode = errorCode;
        }
    }
}
