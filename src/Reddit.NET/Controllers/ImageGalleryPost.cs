using Reddit.Things;
using System;

namespace Reddit.Controllers
{
    public class ImageGalleryPost : Post
    {
        public ImageGallery Images => Listing?.MediaMetadata;

        public ImageGalleryPost(Dispatch dispatch) : base(dispatch)
        {
        }

        public ImageGalleryPost(Dispatch dispatch, Things.Post listing) : base(dispatch, listing)
        {
        }

        public ImageGalleryPost(Dispatch dispatch, string fullname) : base(dispatch, fullname)
        {
        }

        public ImageGalleryPost(Dispatch dispatch, string fullname, string subreddit) : base(dispatch, fullname, subreddit)
        {
        }

        public ImageGalleryPost(Dispatch dispatch, string subreddit, string title = null, string author = null, string id = null, string fullname = null, string permalink = null, DateTime created = default, DateTime edited = default, int score = 0, int upVotes = 0, int downVotes = 0, bool removed = false, bool spam = false, bool nsfw = false) : base(dispatch, subreddit, title, author, id, fullname, permalink, created, edited, score, upVotes, downVotes, removed, spam, nsfw)
        {
        }
    }
}
