using System;
using System.Runtime.Serialization;

[Serializable]
public class UsuarioNaoCadastradoException : Exception
{
    public UsuarioNaoCadastradoException()
    {
    }

    public UsuarioNaoCadastradoException(string message) : base(message)
    {
    }

    public UsuarioNaoCadastradoException(string message, Exception innerException) : base(message, innerException)
    {
    }

    protected UsuarioNaoCadastradoException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}