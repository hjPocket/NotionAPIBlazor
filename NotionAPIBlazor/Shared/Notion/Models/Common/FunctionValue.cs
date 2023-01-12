using System.Runtime.Serialization;

namespace NotionAPIBlazor.Shared.Notion.Models.Common
{
    public enum FunctionValue
    {
        [EnumMember(Value = "count")]
        Count,

        [EnumMember(Value = "count_values")]
        CountValues,

        [EnumMember(Value = "empty")]
        Empty,

        [EnumMember(Value = "not_empty")]
        NotEmpty,

        [EnumMember(Value = "unique")]
        Unique,

        [EnumMember(Value = "show_unique")]
        ShowUnique,

        [EnumMember(Value = "percent_empty")]
        PercentEmpty,

        [EnumMember(Value = "percent_not_empty")]
        PercentNotEmpty,

        [EnumMember(Value = "sum")]
        Sum,

        [EnumMember(Value = "average")]
        Average,

        [EnumMember(Value = "median")]
        Median,

        [EnumMember(Value = "min")]
        Min,

        [EnumMember(Value = "max")]
        Max,

        [EnumMember(Value = "range")]
        Range,

        [EnumMember(Value = "earliest_date")]
        EarliestDate,

        [EnumMember(Value = "latest_date")]
        LatestDate,

        [EnumMember(Value = "date_range")]
        DateRange,

        [EnumMember(Value = "checked")]
        Checked,

        [EnumMember(Value = "unchecked")]
        Unchecked,

        [EnumMember(Value = "percent_checked")]
        PercentChecked,

        [EnumMember(Value = "percent_unchecked")]
        PercentUnchecked,

        [EnumMember(Value = "count_per_group")]
        CountPerGroup,

        [EnumMember(Value = "percent_per_group")]
        PercentPerGroup,

        [EnumMember(Value = "show_original")]
        ShowOriginal,

    }
}
