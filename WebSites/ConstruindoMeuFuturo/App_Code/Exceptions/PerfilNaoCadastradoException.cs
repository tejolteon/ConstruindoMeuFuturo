using System;
using System.Runtime.Serialization;

[Serializable]
public class PerfilNaoCadastradoException : Exception
{
    public PerfilNaoCadastradoException()
    {
    }

    public PerfilNaoCadastradoException(string message) : base(message)
    {
    }

    public PerfilNaoCadastradoException(string message, Exception innerException) : base(message, innerException)
    {
    }

    protected PerfilNaoCadastradoException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}