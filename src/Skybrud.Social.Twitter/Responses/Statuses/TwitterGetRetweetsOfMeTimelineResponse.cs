using System;
using Skybrud.Social.Http;
using Skybrud.Social.Twitter.Models;
using Skybrud.Social.Twitter.Models.Statuses;

namespace Skybrud.Social.Twitter.Responses.Statuses {

    public class TwitterGetRetweetsOfMeTimelineResponse : TwitterResponse<TwitterStatusMessage[]> {

        #region Constructors

        private TwitterGetRetweetsOfMeTimelineResponse(SocialHttpResponse response) : base(response) {
            
            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonArray(response.Body, TwitterStatusMessage.Parse);

        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="response"/> into an instance of <see cref="TwitterGetRetweetsOfMeTimelineResponse"/>.
        /// </summary>
        /// <param name="response">The instance of <see cref="SocialHttpResponse"/> representing the raw response.</param>
        /// <returns>An instance of <see cref="TwitterGetRetweetsOfMeTimelineResponse"/> representing the response.</returns>
        public static TwitterGetRetweetsOfMeTimelineResponse ParseResponse(SocialHttpResponse response) {
            if (response == null) throw new ArgumentNullException(nameof(response));
            return new TwitterGetRetweetsOfMeTimelineResponse(response);
        }

        #endregion

    }

}