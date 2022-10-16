using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Reddit.Things
{
    [Serializable]
    public class LabeledMultiSubmit
    {
        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("subreddits")]
        public List<SubredditName> Subreddits { get; set; }

        [JsonProperty("visibility")]
        public string Visibility { get; set; }

        [JsonProperty("icon_img")]
        public string IconImg { get; set; }

        [JsonProperty("key_color")]
        public string KeyColor { get; set; }

        [JsonProperty("description_md")]
        public string DescriptionMd { get; set; }

        /// <summary>
        /// Create a new multireddit submission object.
        /// </summary>
        /// <param name="descriptionMd">Description of the multireddit in markdown</param>
        /// <param name="displayName">The multireddit name as it appears to users</param>
        /// <param name="iconName">One of (art and design, ask, books, business, cars, comics, cute animals, diy, entertainment, food and drink, funny, 
        /// games, grooming, health, life advice, military, models pinup, music, news, philosophy, pictures and gifs, science, shopping, sports, style, 
        /// tech, travel, unusual stories, video, none)</param>
        /// <param name="keyColor">a 6-digit rgb hex color, e.g. #AABBCC</param>
        /// <param name="subreddits">List of subreddits with which to initially populate the multireddit</param>
        /// <param name="visibility">One of (public, private, hidden)</param>
        /// <param name="weightingScheme">One of (classic, fresh)</param>
        public LabeledMultiSubmit(string descriptionMd, string displayName, string iconImg, string keyColor, List<SubredditName> subreddits, string visibility)
        {
            Import(descriptionMd, displayName, iconImg, keyColor, subreddits, visibility);
        }

        /// <summary>
        /// Create a new multireddit submission object.
        /// </summary>
        /// <param name="descriptionMd">Description of the multireddit in markdown</param>
        /// <param name="displayName">The multireddit name as it appears to users</param>
        /// <param name="iconName">One of (art and design, ask, books, business, cars, comics, cute animals, diy, entertainment, food and drink, funny, 
        /// games, grooming, health, life advice, military, models pinup, music, news, philosophy, pictures and gifs, science, shopping, sports, style, 
        /// tech, travel, unusual stories, video, none)</param>
        /// <param name="keyColor">a 6-digit rgb hex color, e.g. #AABBCC</param>
        /// <param name="subreddits">List of subreddits with which to initially populate the multireddit</param>
        /// <param name="visibility">One of (public, private, hidden)</param>
        /// <param name="weightingScheme">One of (classic, fresh)</param>
        public LabeledMultiSubmit(string descriptionMd, string displayName, string iconImg, string keyColor, List<Subreddit> subreddits, string visibility)
        {
            List<SubredditName> subs = new List<SubredditName>();

            foreach (Subreddit sub in subreddits)
            {
                subs.Add(new SubredditName(sub.DisplayName));
            }

            Import(descriptionMd, displayName, iconImg, keyColor, subs, visibility);
        }

        /// <summary>
        /// Create a new multireddit submission object.
        /// </summary>
        /// <param name="descriptionMd">Description of the multireddit in markdown</param>
        /// <param name="displayName">The multireddit name as it appears to users</param>
        /// <param name="iconName">One of (art and design, ask, books, business, cars, comics, cute animals, diy, entertainment, food and drink, funny, 
        /// games, grooming, health, life advice, military, models pinup, music, news, philosophy, pictures and gifs, science, shopping, sports, style, 
        /// tech, travel, unusual stories, video, none)</param>
        /// <param name="keyColor">a 6-digit rgb hex color, e.g. #AABBCC</param>
        /// <param name="subreddits">List of subreddits with which to initially populate the multireddit</param>
        /// <param name="visibility">One of (public, private, hidden)</param>
        /// <param name="weightingScheme">One of (classic, fresh)</param>
        public LabeledMultiSubmit(string descriptionMd, string displayName, string iconImg, string keyColor, List<Controllers.Subreddit> subreddits, string visibility)
        {
            List<SubredditName> subs = new List<SubredditName>();

            foreach (Controllers.Subreddit sub in subreddits)
            {
                subs.Add(new SubredditName(sub.Name));
            }

            Import(descriptionMd, displayName, iconImg, keyColor, subs, visibility);
        }

        /// <summary>
        /// Create a new multireddit submission object.
        /// </summary>
        /// <param name="descriptionMd">Description of the multireddit in markdown</param>
        /// <param name="displayName">The multireddit name as it appears to users</param>
        /// <param name="iconName">One of (art and design, ask, books, business, cars, comics, cute animals, diy, entertainment, food and drink, funny, 
        /// games, grooming, health, life advice, military, models pinup, music, news, philosophy, pictures and gifs, science, shopping, sports, style, 
        /// tech, travel, unusual stories, video, none)</param>
        /// <param name="keyColor">a 6-digit rgb hex color, e.g. #AABBCC</param>
        /// <param name="subreddits">List of subreddits with which to initially populate the multireddit</param>
        /// <param name="visibility">One of (public, private, hidden)</param>
        /// <param name="weightingScheme">One of (classic, fresh)</param>
        public LabeledMultiSubmit(string descriptionMd, string displayName, string iconImg, string keyColor, List<string> subreddits, string visibility = "private")
        {
            List<SubredditName> subs = new List<SubredditName>();

            foreach (string sub in subreddits)
            {
                subs.Add(new SubredditName(sub));
            }

            Import(descriptionMd, displayName, iconImg, keyColor, subs, visibility);
        }

        public LabeledMultiSubmit() { }

        private void Import(string descriptionMd, string displayName, string iconImg, string keyColor, List<SubredditName> subreddits, string visibility)
        {
            DescriptionMd = descriptionMd;
            DisplayName = displayName;
            IconImg = iconImg;
            KeyColor = keyColor;
            Subreddits = subreddits;
            Visibility = visibility;
        }
    }
}
