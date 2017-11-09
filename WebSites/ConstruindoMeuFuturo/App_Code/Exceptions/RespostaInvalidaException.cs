using System;
using System.Runtime.Serialization;

[Serializable]
public class RespostaInvalidaException : Exception
{
    public RespostaInvalidaException()
    {
      
    }

    public RespostaInvalidaException(string message) : base(message)
    {
    }

    public RespostaInvalidaException(string message, Exception innerException) : base(message, innerException)
    {
    }

    protected RespostaInvalidaException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}