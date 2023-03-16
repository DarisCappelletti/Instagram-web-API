using System.Collections.Generic;

namespace Instagram_API.Models
{
    public class RicercaUtenteIg
    {
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class Hashtag
        {
            public int position { get; set; }
            public Hashtag2 hashtag { get; set; }
        }

        public class Hashtag2
        {
            public string name { get; set; }
            public object id { get; set; }
            public int media_count { get; set; }
            public bool use_default_avatar { get; set; }
            public string search_result_subtitle { get; set; }
        }

        public class LinkedFbInfo
        {
            public LinkedFbUser linked_fb_user { get; set; }
        }

        public class LinkedFbUser
        {
            public string id { get; set; }
            public string name { get; set; }
            public bool is_valid { get; set; }
            public object fb_account_creation_time { get; set; }
            public object link_time { get; set; }
        }

        public class Risultati
        {
            public List<UtenteIg> users { get; set; }
            public List<object> places { get; set; }
            public List<Hashtag> hashtags { get; set; }
            public bool has_more { get; set; }
            public string rank_token { get; set; }
            public object clear_client_cache { get; set; }
            public string status { get; set; }
        }

        public class UtenteIg
        {
            public int position { get; set; }
            public InnerUtenteIg user { get; set; }
        }

        public class InnerUtenteIg
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
            public bool has_opt_eligible_shop { get; set; }
            public List<object> account_badges { get; set; }
            public int latest_reel_media { get; set; }
            public object live_broadcast_id { get; set; }
            public bool should_show_category { get; set; }
            public LinkedFbInfo linked_fb_info { get; set; }
        }
    }
}
