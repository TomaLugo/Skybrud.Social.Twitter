using Skybrud.Social.Twitter.Endpoints.Raw;
using Skybrud.Social.Twitter.Models.Statuses;
using Skybrud.Social.Twitter.Options.Statuses;
using Skybrud.Social.Twitter.Responses.Statuses;

namespace Skybrud.Social.Twitter.Endpoints {

    /// <summary>
    /// Class representing the implementation of the <strong>Statuses</strong> endpoint.
    /// </summary>
    public class TwitterStatusesEndpoint {

        #region Properties

        /// <summary>
        /// Gets a reference to the Twitter service.
        /// </summary>
        public TwitterService Service { get; }

        /// <summary>
        /// Gets a reference to the raw endpoint.
        /// </summary>
        public TwitterStatusesRawEndpoint Raw => Service.Client.Statuses;

        #endregion

        #region Constructors

        internal TwitterStatusesEndpoint(TwitterService service) {
            Service = service;
        }

        #endregion

        #region Member methods

        #region GetStatusMessage(...)

        /// <summary>
        /// Gets information about the status message (tweet) with the <paramref name="statusId"/>.
        /// </summary>
        /// <param name="statusId">The ID of the status message.</param>
        /// <returns>An instance of <see cref="TwitterGetStatusMessageResponse"/> representing the response.</returns>
        /// <see>
        ///     <cref>https://developer.twitter.com/en/docs/tweets/post-and-engage/api-reference/get-statuses-show-id</cref>
        /// </see>
        public TwitterGetStatusMessageResponse GetStatusMessage(long statusId) {
            return TwitterGetStatusMessageResponse.ParseResponse(Raw.GetStatusMessage(statusId));
        }

        /// <summary>
        /// Gets the raw API response for a status message (tweet) matching the specified <paramref name="options"/>.
        /// </summary>
        /// <param name="options">The options used when making the call to the API.</param>
        /// <returns>An instance of <see cref="TwitterGetStatusMessageResponse"/> representing the response.</returns>
        /// <see>
        ///     <cref>https://developer.twitter.com/en/docs/tweets/post-and-engage/api-reference/get-statuses-show-id</cref>
        /// </see>
        public TwitterGetStatusMessageResponse GetStatusMessage(TwitterGetStatusMessageOptions options) {
            return TwitterGetStatusMessageResponse.ParseResponse(Raw.GetStatusMessage(options));
        }

        #endregion

        #region PostStatusMessage(...)

        /// <summary>
        /// Posts the specified status message.
        /// </summary>
        /// <param name="status">The status message to send.</param>
        /// <returns>An instance of <see cref="TwitterPostStatusMessageResponse"/> representing the response.</returns>
        /// <see>
        ///     <cref>https://developer.twitter.com/en/docs/tweets/post-and-engage/api-reference/post-statuses-update</cref>
        /// </see>
        public TwitterPostStatusMessageResponse PostStatusMessage(string status) {
            return TwitterPostStatusMessageResponse.ParseResponse(Raw.PostStatusMessage(status));
        }

        /// <summary>
        /// Posts the specified status message.
        /// </summary>
        /// <param name="status">The status message to send.</param>
        /// <param name="replyTo">The ID of the status message to reply to.</param>
        /// <returns>An instance of <see cref="TwitterPostStatusMessageResponse"/> representing the response.</returns>
        /// <see>
        ///     <cref>https://developer.twitter.com/en/docs/tweets/post-and-engage/api-reference/post-statuses-update</cref>
        /// </see>
        public TwitterPostStatusMessageResponse PostStatusMessage(string status, long? replyTo) {
            return TwitterPostStatusMessageResponse.ParseResponse(Raw.PostStatusMessage(status, replyTo));
        }

        /// <summary>
        /// Posts a new status message (tweet) with the specified <paramref name="options"/>.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        /// <returns>An instance of <see cref="TwitterPostStatusMessageResponse"/> representing the response.</returns>
        /// <see>
        ///     <cref>https://developer.twitter.com/en/docs/tweets/post-and-engage/api-reference/post-statuses-update</cref>
        /// </see>
        public TwitterPostStatusMessageResponse PostStatusMessage(TwitterPostStatusMessageOptions options) {
            return TwitterPostStatusMessageResponse.ParseResponse(Raw.PostStatusMessage(options));
        }

        #endregion

        #region GetUserTimeline(...)

        /// <summary>
        /// Get the raw API response for a user's timeline.
        /// </summary>
        /// <param name="userId">The ID of the user.</param>
        /// <returns>An instance of <see cref="TwitterGetUserTimelineResponse"/> representing the response.</returns>
        /// <see>
        ///     <cref>https://developer.twitter.com/en/docs/tweets/timelines/api-reference/get-statuses-user_timeline</cref>
        /// </see>
        public TwitterGetUserTimelineResponse GetUserTimeline(long userId) {
            return TwitterGetUserTimelineResponse.ParseResponse(Raw.GetUserTimeline(userId));
        }

        /// <summary>
        /// Get the raw API response for a user's timeline.
        /// </summary>
        /// <param name="userId">The ID of the user.</param>
        /// <param name="count">The maximum amount of tweets to return.</param>
        /// <returns>An instance of <see cref="TwitterGetUserTimelineResponse"/> representing the response.</returns>
        /// <see>
        ///     <cref>https://developer.twitter.com/en/docs/tweets/timelines/api-reference/get-statuses-user_timeline</cref>
        /// </see>
        public TwitterGetUserTimelineResponse GetUserTimeline(long userId, int count) {
            return TwitterGetUserTimelineResponse.ParseResponse(Raw.GetUserTimeline(userId, count));
        }

        /// <summary>
        /// Get the raw API response for a user's timeline.
        /// </summary>
        /// <param name="userId">The ID of the user.</param>
        /// <param name="count">The maximum amount of tweets to return.</param>
        /// <param name="maxId">The maximum status message ID. Only status message with an ID less then (that is, older
        /// than) this ID will be returned.</param>
        /// <returns>An instance of <see cref="TwitterGetUserTimelineResponse"/> representing the response.</returns>
        /// <see>
        ///     <cref>https://developer.twitter.com/en/docs/tweets/timelines/api-reference/get-statuses-user_timeline</cref>
        /// </see>
        public TwitterGetUserTimelineResponse GetUserTimeline(long userId, int count, long maxId) {
            return TwitterGetUserTimelineResponse.ParseResponse(Raw.GetUserTimeline(userId, count, maxId));
        }

        /// <summary>
        /// Get the raw API response for a user's timeline.
        /// </summary>
        /// <param name="screenName">The screen name of the user.</param>
        /// <returns>An instance of <see cref="TwitterGetUserTimelineResponse"/> representing the response.</returns>
        /// <see>
        ///     <cref>https://developer.twitter.com/en/docs/tweets/timelines/api-reference/get-statuses-user_timeline</cref>
        /// </see>
        public TwitterGetUserTimelineResponse GetUserTimeline(string screenName) {
            return TwitterGetUserTimelineResponse.ParseResponse(Raw.GetUserTimeline(screenName));
        }

        /// <summary>
        /// Get the raw API response for a user's timeline.
        /// </summary>
        /// <param name="screenName">The screen name of the user.</param>
        /// <param name="count">The maximum amount of tweets to return.</param>
        /// <returns>An instance of <see cref="TwitterGetUserTimelineResponse"/> representing the response.</returns>
        /// <see>
        ///     <cref>https://developer.twitter.com/en/docs/tweets/timelines/api-reference/get-statuses-user_timeline</cref>
        /// </see>
        public TwitterGetUserTimelineResponse GetUserTimeline(string screenName, int count) {
            return TwitterGetUserTimelineResponse.ParseResponse(Raw.GetUserTimeline(screenName, count));
        }

        /// <summary>
        /// Get the raw API response for a user's timeline.
        /// </summary>
        /// <param name="screenName">The screen name of the user.</param>
        /// <param name="count">The maximum amount of tweets to return.</param>
        /// <param name="maxId">The maximum status message ID. Only status message with an ID less then (that is, older
        /// than) this ID will be returned.</param>
        /// <returns>An instance of <see cref="TwitterGetUserTimelineResponse"/> representing the response.</returns>
        /// <see>
        ///     <cref>https://developer.twitter.com/en/docs/tweets/timelines/api-reference/get-statuses-user_timeline</cref>
        /// </see>
        public TwitterGetUserTimelineResponse GetUserTimeline(string screenName, int count, long maxId) {
            return TwitterGetUserTimelineResponse.ParseResponse(Raw.GetUserTimeline(screenName, count, maxId));
        }

        /// <summary>
        /// Get the raw API response for a user's timeline.
        /// </summary>
        /// <param name="options">The options used when making the call to the API.</param>
        /// <returns>An instance of <see cref="TwitterGetUserTimelineResponse"/> representing the response.</returns>
        /// <see>
        ///     <cref>https://developer.twitter.com/en/docs/tweets/timelines/api-reference/get-statuses-user_timeline</cref>
        /// </see>
        public TwitterGetUserTimelineResponse GetUserTimeline(TwitterGetUserTimelineOptions options) {
            return TwitterGetUserTimelineResponse.ParseResponse(Raw.GetUserTimeline(options));
        }

        #endregion

        #region GetHomeTimeline(...)

        /// <summary>
        /// Gets a collection of the most recent tweets and retweets posted by the authenticating
        /// user and the users they follow.
        /// </summary>
        /// <returns>An instance of <see cref="TwitterGetHomeTimelineResponse"/> representing the response.</returns>
        /// <see>
        ///     <cref>https://developer.twitter.com/en/docs/tweets/timelines/api-reference/get-statuses-home_timeline</cref>
        /// </see>
        public TwitterGetHomeTimelineResponse GetHomeTimeline() {
            return TwitterGetHomeTimelineResponse.ParseResponse(Raw.GetHomeTimeline());
        }

        /// <summary>
        /// Gets a collection of the most recent tweets and retweets posted by the authenticating
        /// user and the users they follow.
        /// </summary>
        /// <returns>An instance of <see cref="TwitterGetHomeTimelineResponse"/> representing the response.</returns>
        /// <param name="count">The maximum amount of tweets to return.</param>
        /// <see>
        ///     <cref>https://developer.twitter.com/en/docs/tweets/timelines/api-reference/get-statuses-home_timeline</cref>
        /// </see>
        public TwitterGetHomeTimelineResponse GetHomeTimeline(int count) {
            return TwitterGetHomeTimelineResponse.ParseResponse(Raw.GetHomeTimeline(count));
        }

        /// <summary>
        /// Gets a collection of the most recent tweets and retweets posted by the authenticating
        /// user and the users they follow. 
        /// </summary>
        /// <param name="options">The options for the call.</param>
        /// <returns>An instance of <see cref="TwitterGetHomeTimelineResponse"/> representing the response.</returns>
        /// <see>
        ///     <cref>https://developer.twitter.com/en/docs/tweets/timelines/api-reference/get-statuses-home_timeline</cref>
        /// </see>
        public TwitterGetHomeTimelineResponse GetHomeTimeline(TwitterGetHomeTimelineOptions options) {
            return TwitterGetHomeTimelineResponse.ParseResponse(Raw.GetHomeTimeline(options));
        }

        #endregion

        #region GetMentionsTimeline(...)

        /// <summary>
        /// Gets the most recent mentions (tweets containing the users's @screen_name) for the authenticating user.
        /// </summary>
        /// <returns>An instance of <see cref="TwitterGetMentionsTimelineResponse"/> representing the response.</returns>
        /// <see>
        ///     <cref>https://developer.twitter.com/en/docs/tweets/timelines/api-reference/get-statuses-mentions_timeline</cref>
        /// </see>
        public TwitterGetMentionsTimelineResponse GetMentionsTimeline() {
            return TwitterGetMentionsTimelineResponse.ParseResponse(Raw.GetMentionsTimeline());
        }

        /// <summary>
        /// Gets the most recent mentions (tweets containing the users's @screen_name) for the authenticating user.
        /// </summary>
        /// <param name="count">The maximum amount of tweets to return.</param>
        /// <returns>An instance of <see cref="TwitterGetMentionsTimelineResponse"/> representing the response.</returns>
        /// <see>
        ///     <cref>https://developer.twitter.com/en/docs/tweets/timelines/api-reference/get-statuses-mentions_timeline</cref>
        /// </see>
        public TwitterGetMentionsTimelineResponse GetMentionsTimeline(int count) {
            return TwitterGetMentionsTimelineResponse.ParseResponse(Raw.GetMentionsTimeline(count));
        }

        /// <summary>
        /// Gets the most recent mentions (tweets containing the users's @screen_name) for the authenticating user.
        /// </summary>
        /// <param name="options">The options for the call.</param>
        /// <returns>An instance of <see cref="TwitterGetMentionsTimelineResponse"/> representing the response.</returns>
        /// <see>
        ///     <cref>https://developer.twitter.com/en/docs/tweets/timelines/api-reference/get-statuses-mentions_timeline</cref>
        /// </see>
        public TwitterGetMentionsTimelineResponse GetMentionsTimeline(TwitterGetMentionsTimelineOptions options) {
            return TwitterGetMentionsTimelineResponse.ParseResponse(Raw.GetMentionsTimeline(options));
        }

        #endregion

        #region GetRetweetsOfMe(...)

        /// <summary>
        /// Gets a list of the most recent tweets authored by the authenticating user that have been retweeted by others.
        /// </summary>
        /// <returns>An instance of <see cref="TwitterGetRetweetsOfMeTimelineResponse"/> representing the response.</returns>
        /// <see>
        ///     <cref>https://developer.twitter.com/en/docs/tweets/post-and-engage/api-reference/get-statuses-retweets_of_me</cref>
        /// </see>
        public TwitterGetRetweetsOfMeTimelineResponse GetRetweetsOfMe() {
            return TwitterGetRetweetsOfMeTimelineResponse.ParseResponse(Raw.GetRetweetsOfMe());
        }

        /// <summary>
        /// Gets a list of the most recent tweets authored by the authenticating user that have been retweeted by others.
        /// </summary>
        /// <param name="count">The maximum amount of tweets to return.</param>
        /// <returns>An instance of <see cref="TwitterGetRetweetsOfMeTimelineResponse"/> representing the response.</returns>
        /// <see>
        ///     <cref>https://developer.twitter.com/en/docs/tweets/post-and-engage/api-reference/get-statuses-retweets_of_me</cref>
        /// </see>
        public TwitterGetRetweetsOfMeTimelineResponse GetRetweetsOfMe(int count) {
            return TwitterGetRetweetsOfMeTimelineResponse.ParseResponse(Raw.GetRetweetsOfMe(count));
        }

        /// <summary>
        /// Gets a list of the most recent tweets authored by the authenticating user that have been retweeted by others.
        /// </summary>
        /// <param name="options">The options for the call.</param>
        /// <returns>An instance of <see cref="TwitterGetRetweetsOfMeTimelineResponse"/> representing the response.</returns>
        /// <see>
        ///     <cref>https://developer.twitter.com/en/docs/tweets/post-and-engage/api-reference/get-statuses-retweets_of_me</cref>
        /// </see>
        public TwitterGetRetweetsOfMeTimelineResponse GetRetweetsOfMe(TwitterGetRetweetsOfMeTimelineOptions options) {
            return TwitterGetRetweetsOfMeTimelineResponse.ParseResponse(Raw.GetRetweetsOfMe(options));
        }

        #endregion

        #region RetweetStatusMessage(...)

        /// <summary>
        /// Retweets the status message with the specified <paramref name="statusId"/>.
        /// </summary>
        /// <param name="statusId">The ID of the status message to be retweeted.</param>
        /// <returns>An instance of <see cref="TwitterRetweetStatusMessageResponse"/> representing the response.</returns>
        /// <see>
        ///     <cref>https://developer.twitter.com/en/docs/tweets/post-and-engage/api-reference/post-statuses-retweet-id</cref>
        /// </see>
        public TwitterRetweetStatusMessageResponse RetweetStatusMessage(long statusId) {
            return TwitterRetweetStatusMessageResponse.ParseResponse(Raw.RetweetStatusMessage(statusId));
        }

        /// <summary>
        /// Retweets the status message with the specified <paramref name="statusId"/>.
        /// </summary>
        /// <param name="statusId">The ID of the status message to be retweeted.</param>
        /// <param name="trimUser">When set to <code>true</code>, each tweet returned in a timeline will include a user
        /// object including only the status authors numerical ID. Omit this parameter to receive the complete user
        /// object.</param>
        /// <returns>An instance of <see cref="TwitterRetweetStatusMessageResponse"/> representing the response.</returns>
        /// <see>
        ///     <cref>https://developer.twitter.com/en/docs/tweets/post-and-engage/api-reference/post-statuses-retweet-id</cref>
        /// </see>
        public TwitterRetweetStatusMessageResponse RetweetStatusMessage(long statusId, bool trimUser) {
            return TwitterRetweetStatusMessageResponse.ParseResponse(Raw.RetweetStatusMessage(statusId, trimUser));
        }

        /// <summary>
        /// Retweets the specified <paramref name="statusMessage"/>.
        /// </summary>
        /// <param name="statusMessage">The status message to be retweeted.</param>
        /// <returns>An instance of <see cref="TwitterRetweetStatusMessageResponse"/> representing the response.</returns>
        public TwitterRetweetStatusMessageResponse RetweetStatusMessage(TwitterStatusMessage statusMessage) {
            return TwitterRetweetStatusMessageResponse.ParseResponse(Raw.RetweetStatusMessage(statusMessage));
        }

        /// <summary>
        /// Retweets the specified <paramref name="statusMessage"/>.
        /// </summary>
        /// <param name="statusMessage">The status message to be retweeted.</param>
        /// <param name="trimUser">When set to <code>true</code>, each tweet returned in a timeline will include a user
        /// object including only the status authors numerical ID. Omit this parameter to receive the complete user
        /// object.</param>
        /// <returns>An instance of <see cref="TwitterRetweetStatusMessageResponse"/> representing the response.</returns>
        public TwitterRetweetStatusMessageResponse RetweetStatusMessage(TwitterStatusMessage statusMessage, bool trimUser) {
            return TwitterRetweetStatusMessageResponse.ParseResponse(Raw.RetweetStatusMessage(statusMessage, trimUser));
        }

        #endregion

        #region DestroyStatusMessage(...)

        /// <summary>
        /// Destroys the status message with the specified <paramref name="statusId"/>. The authenticating user must be
        /// the author of the specified status message. Returns the destroyed status message if successful.
        /// </summary>
        /// <param name="statusId">The ID of the status message to be destroyed.</param>
        /// <returns>An instance of <see cref="TwitterDestroyStatusMessageResponse"/> representing the response.</returns>
        /// <see>
        ///     <cref>https://developer.twitter.com/en/docs/tweets/post-and-engage/api-reference/post-statuses-destroy-id</cref>
        /// </see>
        public TwitterDestroyStatusMessageResponse DestroyStatusMessage(long statusId) {
            return TwitterDestroyStatusMessageResponse.ParseResponse(Raw.DestroyStatusMessage(statusId));
        }

        /// <summary>
        /// Destroys the status message with the specified <paramref name="statusId"/>. The authenticating user must be
        /// the author of the specified status message. Returns the destroyed status message if successful.
        /// </summary>
        /// <param name="statusId">The ID of the status message to be destroyed.</param>
        /// <param name="trimUser">When set to <code>true</code>, each tweet returned in a timeline will include a user
        /// object including only the status authors numerical ID. Omit this parameter to receive the complete user
        /// object.</param>
        /// <returns>An instance of <see cref="TwitterDestroyStatusMessageResponse"/> representing the response.</returns>
        /// <see>
        ///     <cref>https://developer.twitter.com/en/docs/tweets/post-and-engage/api-reference/post-statuses-destroy-id</cref>
        /// </see>
        public TwitterDestroyStatusMessageResponse DestroyStatusMessage(long statusId, bool trimUser) {
            return TwitterDestroyStatusMessageResponse.ParseResponse(Raw.DestroyStatusMessage(statusId, trimUser));
        }

        /// <summary>
        /// Destroys the specified <paramref name="statusMessage"/>. The authenticating user must be the author of the
        /// specified status message. Returns the destroyed status message if successful.
        /// </summary>
        /// <param name="statusMessage">The status meessage to be destroyed.</param>
        /// <returns>An instance of <see cref="TwitterDestroyStatusMessageResponse"/> representing the response.</returns>
        public TwitterDestroyStatusMessageResponse DestroyStatusMessage(TwitterStatusMessage statusMessage) {
            return TwitterDestroyStatusMessageResponse.ParseResponse(Raw.DestroyStatusMessage(statusMessage));
        }

        /// <summary>
        /// Destroys the specified <paramref name="statusMessage"/>. The authenticating user must be the author of the
        /// specified status message. Returns the destroyed status message if successful.
        /// </summary>
        /// <param name="statusMessage">The status meessage to be destroyed.</param>
        /// <param name="trimUser">When set to <code>true</code>, each tweet returned in a timeline will include a user
        /// object including only the status authors numerical ID. Omit this parameter to receive the complete user
        /// object.</param>
        /// <returns>An instance of <see cref="TwitterDestroyStatusMessageResponse"/> representing the response.</returns>
        public TwitterDestroyStatusMessageResponse DestroyStatusMessage(TwitterStatusMessage statusMessage, bool trimUser) {
            return TwitterDestroyStatusMessageResponse.ParseResponse(Raw.DestroyStatusMessage(statusMessage, trimUser));
        }

        #endregion

        #endregion

    }

}