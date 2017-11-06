using System;
using System.Runtime.Serialization;

[Serializable]
public class EmailJaCadastradoException : Exception
{
    public EmailJaCadastradoException()
    {
      
    }

    public EmailJaCadastradoException(string message) : base(message)
    {
    }

    public EmailJaCadastradoException(string message, Exception innerException) : base(message, innerException)
    {
    }

    protected EmailJaCadastradoException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}