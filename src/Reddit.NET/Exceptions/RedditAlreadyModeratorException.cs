using System;
using System.Runtime.Serialization;

namespace Reddit.Exceptions
{
    /// <summary>
    /// An <see cref="Exception"/> which gets triggered when the user is already a moderator of the subreddit.
    /// </summary>
    [Serializable]
    public class RedditAlreadyModeratorException : Exception
    {
        public RedditAlreadyModeratorException(string message, Exception inner)
            : base(message, inner) { }

        public RedditAlreadyModeratorException(string message)
            : base(message) { }

        public RedditAlreadyModeratorException() { }

        protected RedditAlreadyModeratorException(SerializationInfo serializationInfo, StreamingContext context)
            : base(serializationInfo, context) { }
    }
}
