using System;
using System.Runtime.Serialization;

namespace Reddit.Exceptions
{
    /// <summary>
    /// An <see cref="Exception"/> which gets triggered when the user already submitted the same thing.
    /// </summary>
    [Serializable]
    public class RedditAlreadySubmittedException : Exception
    {
        public RedditAlreadySubmittedException(string message, Exception inner)
            : base(message, inner) { }

        public RedditAlreadySubmittedException(string message)
            : base(message) { }

        public RedditAlreadySubmittedException() { }

        protected RedditAlreadySubmittedException(SerializationInfo serializationInfo, StreamingContext context)
            : base(serializationInfo, context) { }
    }
}
