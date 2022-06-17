using System;
using System.Runtime.Serialization;

namespace Reddit.Exceptions
{
    /// <summary>
    /// An <see cref="Exception"/> which gets triggered when there's a conflict.
    /// </summary>
    [Serializable]
    public class RedditConflictException : Exception
    {
        public RedditConflictException(string message, Exception inner)
            : base(message, inner) { }

        public RedditConflictException(string message)
            : base(message) { }

        public RedditConflictException() { }

        protected RedditConflictException(SerializationInfo serializationInfo, StreamingContext context)
            : base(serializationInfo, context) { }
    }
}
