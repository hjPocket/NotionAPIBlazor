namespace NotionAPI.Client
{
    public class NotionCode
    {
        public string grant_type { get; set; }
        public string code { get; set; }
        public string redirect_url { get; set; }
    }
}
