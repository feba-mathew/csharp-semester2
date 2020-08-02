using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld.Models
{
    public class Description_annotations
    {
    }

    public class TagsItem
    {
        /// <summary>
        /// 
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string display_name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int followers { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int total_items { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string following { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string is_whitelisted { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string background_hash { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string thumbnail_hash { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string accent { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string background_is_animated { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string thumbnail_is_animated { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string is_promoted { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string description { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string logo_hash { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string logo_destination_url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Description_annotations description_annotations { get; set; }
    }

    public class ImagesItem
    {
        /// <summary>
        /// 
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string title { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string description { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int datetime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string animated { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int width { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int height { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int size { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int views { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long bandwidth { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string vote { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string favorite { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string nsfw { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string section { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string account_url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string account_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string is_ad { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string in_most_viral { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string has_sound { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<string> tags { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int ad_type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ad_url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string edited { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string in_gallery { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string link { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string comment_count { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string favorite_count { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ups { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string downs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string points { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string score { get; set; }
    }

    public class Ad_config
    {
        /// <summary>
        /// 
        /// </summary>
        public List<string> safeFlags { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<string> highRiskFlags { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<string> unsafeFlags { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<string> wallUnsafeFlags { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string showsAds { get; set; }
    }

    public class ItemsItem
    {
        /// <summary>
        /// 
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string title { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string description { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int datetime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string cover { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int cover_width { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int cover_height { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string account_url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int account_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string privacy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string layout { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int views { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string link { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int ups { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int downs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int points { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int score { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string is_album { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string vote { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string favorite { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string nsfw { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string section { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int comment_count { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int favorite_count { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string topic { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int topic_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int images_count { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string in_gallery { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string is_ad { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<TagsItem> tags { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int ad_type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ad_url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string in_most_viral { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string include_album_ads { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<ImagesItem> images { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Ad_config ad_config { get; set; }
    }

    public class Data
    {
        /// <summary>
        /// 
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string display_name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int followers { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int total_items { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string following { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string is_whitelisted { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string background_hash { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string thumbnail_hash { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string accent { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string background_is_animated { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string thumbnail_is_animated { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string is_promoted { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string description { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string logo_hash { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string logo_destination_url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Description_annotations description_annotations { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<ItemsItem> items { get; set; }
    }

    public class ImageModel
    {
        /// <summary>
        /// 
        /// </summary>
        public Data data { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string success { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int status { get; set; }
    }
}
