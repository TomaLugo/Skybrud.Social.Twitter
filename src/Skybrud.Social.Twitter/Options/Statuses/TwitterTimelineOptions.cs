using Skybrud.Essentials.Strings;
using Skybrud.Social.Http;
using Skybrud.Social.Interfaces.Http;

namespace Skybrud.Social.Twitter.Options.Statuses {

    public abstract class TwitterTimelineOptions : IHttpGetOptions {

        #region Properties

        /// <summary>
        /// Returns results with an ID greater than (that is, more recent than) the specified ID. There are limits to
        /// the number of tweets which can be accessed through the API. If the limit of tweets has occured since the
        /// <code>since_id</code>, the <code>since_id</code> will be forced to the oldest ID available.
        /// </summary>
        public long SinceId { get; set; }

        /// <summary>
        /// Specifies the number of tweets to try and retrieve, up to a maximum of 200 per distinct request. The value
        /// of count is best thought of as a limit to the number of tweets to return because suspended or deleted
        /// content is removed after the count has been applied.
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// Returns results with an ID less than (that is, older than) or equal to the specified ID.
        /// </summary>
        public long MaxId { get; set; }

        /// <summary>
        /// When set to true, each tweet returned in a timeline will include a user object including only the status
        /// authors numerical ID. Omit this parameter to receive the complete user object.
        /// </summary>
        public bool TrimUser { get; set; }

        /// <summary>
        /// This parameter will prevent replies from appearing in the returned timeline. Using
        /// <code>exclude_replies</code> with the <code>count</code> parameter will mean you will receive up-to count
        /// tweets — this is because the <code>count</code> parameter retrieves that many tweets before filtering out
        /// retweets and replies.
        /// </summary>
        public bool ExcludeReplies { get; set; }

        /// <summary>
        /// This parameter enhances the contributors element of the status response to include the
        /// <code>screen_name</code> of the contributor. By default only the <code>user_id</code> of the contributor is
        /// included.
        /// </summary>
        public bool ContributorDetails { get; set; }

        /// <summary>
        /// When set to <code>false</code>, the timeline will strip any native retweets (though they will still count
        /// toward both the maximal length of the timeline and the slice selected by the count parameter).
        /// 
        /// Note: If you're using the <code>trim_user</code> parameter in conjunction with <code>include_rts</code>,
        /// the retweets will still contain a full user object.
        /// </summary>
        public bool IncludeRetweets { get; set; }

        /// <summary>
        /// Gets or sets the tweet mode, qhich determines the JSON payload of each tweet. Default is <see cref="TwitterTweetMode.Compatibility"/>.
        /// </summary>
        /// <see>
        ///     <cref>https://developer.twitter.com/en/docs/tweets/tweet-updates#overview</cref>
        /// </see>
        public TwitterTweetMode TweetMode { get; set; }

        #endregion

        #region Constructors

        protected TwitterTimelineOptions() {
            IncludeRetweets = true;
        }

        protected TwitterTimelineOptions(int count) {
            Count = count;
            IncludeRetweets = true;
        }

        #endregion

        #region Member methods

        public IHttpQueryString GetQueryString() {

            // Define the query string
            SocialHttpQueryString qs = new SocialHttpQueryString();

            // Add optional parameters
            if (SinceId > 0) qs.Add("since_id", SinceId);
            if (Count > 0) qs.Add("count", Count);
            if (MaxId > 0) qs.Add("max_id", MaxId);
            if (TrimUser) qs.Add("trim_user", "true");
            if (ExcludeReplies) qs.Add("exclude_replies", "true");
            if (ContributorDetails) qs.Add("contributor_details", "true");
            if (!IncludeRetweets) qs.Add("include_rts", "false");
            if (TweetMode != TwitterTweetMode.Compatibility) qs.Add("tweet_mode", StringUtils.ToCamelCase(TweetMode));

            return qs;

        }

        #endregion

    }

}