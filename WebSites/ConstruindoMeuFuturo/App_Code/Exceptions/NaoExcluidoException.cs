using System;
using System.Runtime.Serialization;

[Serializable]
public class NaoExcluidoException : Exception
{
    public NaoExcluidoException()
    {
      
    }

    public NaoExcluidoException(string message) : base(message)
    {
    }

    public NaoExcluidoException(string message, Exception innerException) : base(message, innerException)
    {
    }

    protected NaoExcluidoException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}