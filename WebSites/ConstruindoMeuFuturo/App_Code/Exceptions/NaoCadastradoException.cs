using System;
using System.Runtime.Serialization;

[Serializable]
public class NaoCadastradoException : Exception
{
    public NaoCadastradoException()
    {
      
    }

    public NaoCadastradoException(string message) : base(message)
    {
    }

    public NaoCadastradoException(string message, Exception innerException) : base(message, innerException)
    {
    }

    protected NaoCadastradoException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}