using System;
using System.Runtime.Serialization;

[Serializable]
public class CursoNaoExcluidoException : Exception
{
    public CursoNaoExcluidoException()
    {
      
    }

    public CursoNaoExcluidoException(string message) : base(message)
    {
    }

    public CursoNaoExcluidoException(string message, Exception innerException) : base(message, innerException)
    {
    }

    protected CursoNaoExcluidoException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}