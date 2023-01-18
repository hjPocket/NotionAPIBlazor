using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace NotionAPIBlazor.Shared.Notion.Models.Common.Parent
{
    public enum ParentType
    {
        [EnumMember(Value = null)]
        Unknown,

        [EnumMember(Value = "database_id")]
        DatabaseId,

        [EnumMember(Value = "page_id")]
        PageId,

        [EnumMember(Value = "workspace")]
        Workspace,

        [EnumMember(Value = "block_id")]
        BlockId
    }
}
