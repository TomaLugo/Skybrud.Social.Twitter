using System;
using Skybrud.Social.Twitter.Endpoints.Raw;
using Skybrud.Social.Twitter.Models;
using Skybrud.Social.Twitter.Options;
using Skybrud.Social.Twitter.Options.StatusMessages;
using Skybrud.Social.Twitter.Responses;
using Skybrud.Social.Twitter.Responses.Statuses;

namespace Skybrud.Social.Twitter.Endpoints {

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

        /// <summary>
        /// Gets information about the status message (tweet) with the <paramref name="statusId"/>.
        /// </summary>
        /// <param name="statusId">The ID of the status message.</param>
        /// <returns>An instance <see cref="TwitterGetStatusMessageResponse"/> representing the response.</returns>
        public TwitterGetStatusMessageResponse GetStatusMessage(long statusId) {
            return TwitterGetStatusMessageResponse.ParseResponse(Raw.GetStatusMessage(statusId));
        }

        /// <summary>
        /// Gets information about the status message (tweet) matching the specified <paramref name="options"/>.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        /// <returns>An instance <see cref="TwitterGetStatusMessageResponse"/> representing the response.</returns>
        public TwitterGetStatusMessageResponse GetStatusMessage(TwitterGetStatusMessageOptions options) {
            return TwitterGetStatusMessageResponse.ParseResponse(Raw.GetStatusMessage(options));
        }

        /// <summary>
        /// Posts the specified status message.
        /// </summary>
        /// <param name="status">The status message to send.</param>
        /// <returns>An instance <see cref="TwitterPostStatusMessageResponse"/> representing the response.</returns>
        public TwitterPostStatusMessageResponse PostStatusMessage(string status) {
            return TwitterPostStatusMessageResponse.ParseResponse(Raw.PostStatusMessage(status));
        }

        /// <summary>
        /// Posts the specified status message.
        /// </summary>
        /// <param name="status">The status message to send.</param>
        /// <param name="replyTo">The ID of the status message to reply to.</param>
        /// <returns>An instance <see cref="TwitterPostStatusMessageResponse"/> representing the response.</returns>
        public TwitterPostStatusMessageResponse PostStatusMessage(string status, long? replyTo) {
            return TwitterPostStatusMessageResponse.ParseResponse(Raw.PostStatusMessage(status, replyTo));
        }

        /// <summary>
        /// Posts the specified status message.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        /// <returns>An instance <see cref="TwitterPostStatusMessageResponse"/> representing the response.</returns>
        public TwitterPostStatusMessageResponse PostStatusMessage(TwitterPostStatusMessageOptions options) {
            return TwitterPostStatusMessageResponse.ParseResponse(Raw.PostStatusMessage(options));
        }

        #region GetUserTimeline(...)

        /// <summary>
        /// Gets the timeline of the user with the specified <paramref name="userId"/>.
        /// </summary>
        /// <param name="userId">The ID of the user.</param>
        /// <param name="count">The maximum amount of tweets to return.</param>
        public TwitterGetUserTimelineResponse GetUserTimeline(long userId, int count) {
            return TwitterGetUserTimelineResponse.ParseResponse(Raw.GetUserTimeline(userId, count));
        }

        /// <summary>
        /// Gets the timeline of the user with the specified <paramref name="userId"/>.
        /// </summary>
        /// <param name="userId">The ID of the user.</param>
        public TwitterGetUserTimelineResponse GetUserTimeline(long userId) {
            return TwitterGetUserTimelineResponse.ParseResponse(Raw.GetUserTimeline(userId));
        }

        /// <summary>
        /// Gets the timeline of the user with the specified <code>userId</code>.
        /// </summary>
        /// <param name="screenName">The screen name of the user.</param>
        public TwitterGetUserTimelineResponse GetUserTimeline(string screenName) {
            return TwitterGetUserTimelineResponse.ParseResponse(Raw.GetUserTimeline(screenName));
        }

        /// <summary>
        /// Gets the timeline of the user with the specified <code>userId</code>.
        /// </summary>
        /// <param name="screenName">The screen name of the user.</param>
        /// <param name="count">The maximum amount of tweets to return.</param>
        public TwitterGetUserTimelineResponse GetUserTimeline(string screenName, int count) {
            return TwitterGetUserTimelineResponse.ParseResponse(Raw.GetUserTimeline(screenName, count));
        }

        /// <summary>
        /// Gets the timeline of a user with the specified <code>options</code>.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        public TwitterGetUserTimelineResponse GetUserTimeline(TwitterGetUserTimelineOptions options) {
            return TwitterGetUserTimelineResponse.ParseResponse(Raw.GetUserTimeline(options));
        }

        #endregion

        /// <summary>
        /// Gets a collection of the most recent tweets and retweets posted by the authenticating
        /// user and the users they follow.
        /// </summary>
        public TwitterTimelineResponse GetHomeTimeline() {
            return TwitterTimelineResponse.ParseResponse(Raw.GetHomeTimeline());
        }

        /// <summary>
        /// Gets a collection of the most recent tweets and retweets posted by the authenticating
        /// user and the users they follow.
        /// </summary>
        /// <param name="count">The maximum amount of tweets to return.</param>
        public TwitterTimelineResponse GetHomeTimeline(int count) {
            return TwitterTimelineResponse.ParseResponse(Raw.GetHomeTimeline(count));
        }

        /// <summary>
        /// Gets a collection of the most recent Tweets and retweets posted by the authenticating
        /// user and the users they follow. 
        /// </summary>
        /// <param name="options">The options for the call.</param>
        public TwitterTimelineResponse GetHomeTimeline(TwitterGetHomeTimelineOptions options) {
            return TwitterTimelineResponse.ParseResponse(Raw.GetHomeTimeline(options));
        }

        /// <summary>
        /// Gets the most recent mentions (tweets containing the users's @screen_name) for the authenticating user.
        /// </summary>
        public TwitterTimelineResponse GetMentionsTimeline() {
            return TwitterTimelineResponse.ParseResponse(Raw.GetMentionsTimeline());
        }

        /// <summary>
        /// Gets the most recent mentions (tweets containing the users's @screen_name) for the authenticating user.
        /// </summary>
        /// <param name="count">The maximum amount of tweets to return.</param>
        public TwitterTimelineResponse GetMentionsTimeline(int count) {
            return TwitterTimelineResponse.ParseResponse(Raw.GetMentionsTimeline(count));
        }

        /// <summary>
        /// Gets the most recent mentions (tweets containing the users's @screen_name) for the authenticating user.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        public TwitterTimelineResponse GetMentionsTimeline(TwitterGetMentionsTimelineOptions options) {
            return TwitterTimelineResponse.ParseResponse(Raw.GetMentionsTimeline(options));
        }

        /// <summary>
        /// Returns the most recent tweets authored by the authenticating user that have been retweeted by others.
        /// </summary>
        public TwitterTimelineResponse GetRetweetsOfMe() {
            return TwitterTimelineResponse.ParseResponse(Raw.GetRetweetsOfMe());
        }

        /// <summary>
        /// Returns the most recent tweets authored by the authenticating user that have been retweeted by others.
        /// </summary>
        /// <param name="count">The maximum amount of tweets to return.</param>
        public TwitterTimelineResponse GetRetweetsOfMe(int count) {
            return TwitterTimelineResponse.ParseResponse(Raw.GetRetweetsOfMe(count));
        }

        /// <summary>
        /// Returns the most recent tweets authored by the authenticating user that have been retweeted by others.
        /// </summary>
        /// <param name="options">The options for the call.</param>
        public TwitterTimelineResponse GetRetweetsOfMe(TwitterGetRetweetsOfMeTimelineOptions options) {
            return TwitterTimelineResponse.ParseResponse(Raw.GetRetweetsOfMe(options));
        }

        /// <summary>
        /// Retweets the status with the specified <code>id</code>.
        /// </summary>
        /// <param name="id">The ID of the tweet to be retweeted.</param>
        /// <returns>Returns the response from the API.</returns>
        public TwitterGetStatusMessageResponse Retweet(long id) {
            return Retweet(id, false);
        }

        /// <summary>
        /// Retweets the status with the specified <code>id</code>.
        /// </summary>
        /// <param name="id">The ID of the tweet to be retweeted.</param>
        /// <param name="trimUser">When set to <code>true</code>, each tweet returned in a timeline will include a user
        /// object including only the status authors numerical ID. Omit this parameter to receive the complete user
        /// object.</param>
        /// <returns>Returns the response from the API.</returns>
        public TwitterGetStatusMessageResponse Retweet(long id, bool trimUser) {
            return TwitterGetStatusMessageResponse.ParseResponse(Raw.Retweet(id, trimUser));
        }

        /// <summary>
        /// Retweets the specified <code>status</code>.
        /// </summary>
        /// <param name="status">The tweet to be retweeted.</param>
        /// <returns>Returns the response from the API.</returns>
        public TwitterGetStatusMessageResponse Retweet(TwitterStatusMessage status) {
            if (status == null) throw new ArgumentNullException(nameof(status));
            return Retweet(status.Id, false);
        }

        /// <summary>
        /// Retweets the specified <paramref name="status"/>.
        /// </summary>
        /// <param name="status">The status to be retweeted.</param>
        /// <param name="trimUser">When set to <code>true</code>, each tweet returned in a timeline will include a user
        /// object including only the status authors numerical ID. Omit this parameter to receive the complete user
        /// object.</param>
        /// <returns>Returns the response from the API.</returns>
        public TwitterGetStatusMessageResponse Retweet(TwitterStatusMessage status, bool trimUser) {
            if (status == null) throw new ArgumentNullException(nameof(status));
            return Retweet(status.Id, trimUser);
        }

        /// <summary>
        /// Destroys the status with the specified <paramref name="id"/>. The authenticating user must be the author of the
        /// specified status. Returns the destroyed status if successful.
        /// </summary>
        /// <param name="id">The ID of the status to be destroyed.</param>
        /// <returns>Returns the response from the API.</returns>
        public TwitterGetStatusMessageResponse DestroyStatusMessage(long id) {
            return DestroyStatusMessage(id, false);
        }

        /// <summary>
        /// Destroys the status with the specified <paramref name="id"/>. The authenticating user must be the author of the
        /// specified status. Returns the destroyed status if successful.
        /// </summary>
        /// <param name="id">The ID of the status to be destroyed.</param>
        /// <param name="trimUser">When set to <code>true</code>, each tweet returned in a timeline will include a user
        /// object including only the status authors numerical ID. Omit this parameter to receive the complete user
        /// object.</param>
        /// <returns>Returns the response from the API.</returns>
        public TwitterGetStatusMessageResponse DestroyStatusMessage(long id, bool trimUser) {
            return TwitterGetStatusMessageResponse.ParseResponse(Raw.DestroyStatusMessage(id, trimUser));
        }

        /// <summary>
        /// Destroys the specified <paramref name="status"/>. The authenticating user must be the author of the
        /// specified status. Returns the destroyed status if successful.
        /// </summary>
        /// <param name="status">The status to be destroyed.</param>
        /// <returns>Returns the response from the API.</returns>
        public TwitterGetStatusMessageResponse DestroyStatusMessage(TwitterStatusMessage status) {
            if (status == null) throw new ArgumentNullException(nameof(status));
            return DestroyStatusMessage(status.Id, false);
        }

        /// <summary>
        /// Destroys the specified <paramref name="status"/>. The authenticating user must be the author of the
        /// specified status. Returns the destroyed status if successful.
        /// </summary>
        /// <param name="status">The status to be destroyed.</param>
        /// <param name="trimUser">When set to <code>true</code>, each tweet returned in a timeline will include a user
        /// object including only the status authors numerical ID. Omit this parameter to receive the complete user
        /// object.</param>
        /// <returns>Returns the response from the API.</returns>
        public TwitterGetStatusMessageResponse DestroyStatusMessage(TwitterStatusMessage status, bool trimUser) {
            if (status == null) throw new ArgumentNullException(nameof(status));
            return DestroyStatusMessage(status.Id, trimUser);
        }

        #endregion

    }

}