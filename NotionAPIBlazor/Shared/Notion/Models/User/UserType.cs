using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace NotionAPIBlazor.Shared.Notion.Models.User
{
    public enum UserType
    {
        [EnumMember(Value = "person")]
        Person,

        [EnumMember(Value = "bot")]
        Bot
    }
}
