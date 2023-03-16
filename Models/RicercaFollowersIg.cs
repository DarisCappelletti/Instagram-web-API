using System.Collections.Generic;

namespace Instagram_API.Models
{
    public class RicercaFollowersIg
    {
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class Lista
        {
            public List<User> users { get; set; }
            public bool big_list { get; set; }
            public int page_size { get; set; }
            public string next_max_id { get; set; }
            public bool has_more { get; set; }
            public bool should_limit_list_of_followers { get; set; }
            public string status { get; set; }
        }

        public class User
        {
            public bool has_anonymous_profile_picture { get; set; }
            public string pk { get; set; }
            public string pk_id { get; set; }
            public string strong_id__ { get; set; }
            public string username { get; set; }
            public string full_name { get; set; }
            public bool is_private { get; set; }
            public bool is_verified { get; set; }
            public string profile_pic_id { get; set; }
            public string profile_pic_url { get; set; }
            public List<object> account_badges { get; set; }
            public int latest_reel_media { get; set; }
        }
    }
}
