using System;
using System.Runtime.Serialization;

[Serializable]
public class SenhaUsuarioInvalidaException : Exception
{
    public SenhaUsuarioInvalidaException()
    {
    }

    public SenhaUsuarioInvalidaException(string message) : base(message)
    {
    }

    public SenhaUsuarioInvalidaException(string message, Exception innerException) : base(message, innerException)
    {
    }

    protected SenhaUsuarioInvalidaException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}