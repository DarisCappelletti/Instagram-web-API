// chiamata user ig
using System.Collections.Generic;

namespace Instagram_API.Models
{
    public class ChiamataUserIg
    {
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class BiographyWithEntities
        {
            public string raw_text { get; set; }
            public List<object> entities { get; set; }
        }

        public class BioLink
        {
            public string title { get; set; }
            public string lynx_url { get; set; }
            public string url { get; set; }
            public string link_type { get; set; }
        }

        public class Data
        {
            public Utente user { get; set; }
        }

        public class EdgeFollow
        {
            public int count { get; set; }
        }

        public class EdgeFollowedBy
        {
            public int count { get; set; }
        }

        public class EdgeLikedBy
        {
            public int count { get; set; }
        }

        public class EdgeMutualFollowedBy
        {
            public int count { get; set; }
            public List<object> edges { get; set; }
        }

        public class EdgeRelatedProfiles
        {
            public List<object> edges { get; set; }
        }

        public class Owner
        {
            public string id { get; set; }
            public string username { get; set; }
        }

        public class PageInfo
        {
            public bool has_next_page { get; set; }
            public string end_cursor { get; set; }
        }

        public class PinnedForUser
        {
            public string id { get; set; }
            public bool is_verified { get; set; }
            public string profile_pic_url { get; set; }
            public string username { get; set; }
        }

        public class RootUtenteIG
        {
            public Data data { get; set; }
            public string status { get; set; }
        }

        public class SharingFrictionInfo
        {
            public bool should_have_sharing_friction { get; set; }
            public object bloks_app_url { get; set; }
        }

        public class ThumbnailResource
        {
            public string src { get; set; }
            public int config_width { get; set; }
            public int config_height { get; set; }
        }

        public class Utente
        {
            public string biography { get; set; }
            public List<BioLink> bio_links { get; set; }
            public BiographyWithEntities biography_with_entities { get; set; }
            public bool blocked_by_viewer { get; set; }
            public object restricted_by_viewer { get; set; }
            public bool country_block { get; set; }
            public string external_url { get; set; }
            public string external_url_linkshimmed { get; set; }
            public EdgeFollowedBy edge_followed_by { get; set; }
            public string fbid { get; set; }
            public bool followed_by_viewer { get; set; }
            public EdgeFollow edge_follow { get; set; }
            public bool follows_viewer { get; set; }
            public string full_name { get; set; }
            public object group_metadata { get; set; }
            public bool has_ar_effects { get; set; }
            public bool has_clips { get; set; }
            public bool has_guides { get; set; }
            public bool has_channel { get; set; }
            public bool has_blocked_viewer { get; set; }
            public int highlight_reel_count { get; set; }
            public bool has_requested_viewer { get; set; }
            public bool hide_like_and_view_counts { get; set; }
            public string id { get; set; }
            public bool is_business_account { get; set; }
            public bool is_professional_account { get; set; }
            public bool is_supervision_enabled { get; set; }
            public bool is_guardian_of_viewer { get; set; }
            public bool is_supervised_by_viewer { get; set; }
            public bool is_supervised_user { get; set; }
            public bool is_embeds_disabled { get; set; }
            public bool is_joined_recently { get; set; }
            public object guardian_id { get; set; }
            public object business_address_json { get; set; }
            public string business_contact_method { get; set; }
            public object business_email { get; set; }
            public object business_phone_number { get; set; }
            public object business_category_name { get; set; }
            public object overall_category_name { get; set; }
            public object category_enum { get; set; }
            public string category_name { get; set; }
            public bool is_private { get; set; }
            public bool is_verified { get; set; }
            public EdgeMutualFollowedBy edge_mutual_followed_by { get; set; }
            public string profile_pic_url { get; set; }
            public string profile_pic_url_hd { get; set; }
            public bool requested_by_viewer { get; set; }
            public bool should_show_category { get; set; }
            public bool should_show_public_contacts { get; set; }
            public object transparency_label { get; set; }
            public string transparency_product { get; set; }
            public string username { get; set; }
            public object connected_fb_page { get; set; }
            public List<object> pronouns { get; set; }
            public EdgeRelatedProfiles edge_related_profiles { get; set; }
        }


    }
}
