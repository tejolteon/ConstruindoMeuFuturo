using System;
using System.Runtime.Serialization;

[Serializable]
public class UsuarioInvalidoException : Exception
{
    public UsuarioInvalidoException()
    {
    }

    public UsuarioInvalidoException(string message) : base(message)
    {
    }

    public UsuarioInvalidoException(string message, Exception innerException) : base(message, innerException)
    {
    }

    protected UsuarioInvalidoException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}