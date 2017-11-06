using System;
using System.Runtime.Serialization;

[Serializable]
public class UnidadeInvalidaException : Exception
{
    public UnidadeInvalidaException()
    {
    }

    public UnidadeInvalidaException(string message) : base(message)
    {
    }

    public UnidadeInvalidaException(string message, Exception innerException) : base(message, innerException)
    {
    }

    protected UnidadeInvalidaException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}