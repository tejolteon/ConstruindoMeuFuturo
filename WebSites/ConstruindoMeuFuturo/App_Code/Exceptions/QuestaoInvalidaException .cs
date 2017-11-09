using System;
using System.Runtime.Serialization;

[Serializable]
public class QuestaoInvalidaException : Exception
{
    public QuestaoInvalidaException()
    {
      
    }

    public QuestaoInvalidaException(string message) : base(message)
    {
    }

    public QuestaoInvalidaException(string message, Exception innerException) : base(message, innerException)
    {
    }

    protected QuestaoInvalidaException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}