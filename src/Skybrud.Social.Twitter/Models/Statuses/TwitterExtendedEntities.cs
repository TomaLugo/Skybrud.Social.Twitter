﻿using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;
using Skybrud.Social.Twitter.Entities;

namespace Skybrud.Social.Twitter.Models.Statuses {
    
    /// <summary>
    /// Class representing the extended entities property of a status message.
    /// </summary>
    public class TwitterExtendedEntities : TwitterObject {

        #region Properties

        /// <summary>
        /// Gets an array of all media mentioned in the parent status message.
        /// </summary>
        public TwitterMediaEntity[] Media { get; private set; }

        #endregion

        #region Constructors

        private TwitterExtendedEntities(JObject obj) : base(obj) {
            Media = obj.GetArray("media", TwitterMediaEntity.Parse);
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Gets an instance of <see cref="TwitterExtendedEntities"/> from the specified <paramref name="obj"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>An instance of <see cref="TwitterExtendedEntities"/>.</returns>
        public static TwitterExtendedEntities Parse(JObject obj) {
            return obj == null ? null : new TwitterExtendedEntities(obj);
        }

        #endregion

    }

}