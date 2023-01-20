using NotionAPIBlazor.Shared.Notion.Models.Common.File;
using NotionAPIBlazor.Shared.Notion.Models.Common.RichText;
using NotionAPIBlazor.Shared.Notion.Models.User;


/* **
 * Author   : Heonji
 * Version  : v0.1
 * Desc     : type 별로 properties에 들어가는 값 다름
 * 
 * **/
namespace NotionAPIBlazor.Shared.Notion.Models.Pages.Properties
{
    public class PageProperty
    {
        public string id { get; set; }

        public string type { get; set; }

        public List<RichText>? title { get; set; }

        public List<RichText>? rich_text { get; set; }

        public int? number { get; set; }

        public PageCommonObject? select { get; set; }

        public PageCommonObject? status { get; set; }

        public List<PageCommonObject>? multi_select { get; set; }

        public PageDateObject? date { get; set; }

        public List<User.User>? people { get; set; }

        public FileObject? files { get; set; }

        public bool? checkbox { get; set;}

        public string? url { get; set; }

        public string? email { get; set; }

        public string? phone_number { get; set; }

        public PageFormulaObject? formula { get; set; }

        public PageRelationObject? relation { get; set; }

        public PageRollupObject? rollup { get; set; }

        public string? created_time { get; set; }

        public User.User? created_by { get; set; }

        public string? last_edited_time { get; set; }

        public User.User? last_edited_by { get; set; }
    }
}
