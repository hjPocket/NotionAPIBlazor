using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace NotionAPIBlazor.Server.Notion.Models.Common
{
    public enum FormatValue
    {
        [EnumMember(Value = "number")]
        Number,

        [EnumMember(Value = "number_with_commas")]
        NumberWithCommas,

        [EnumMember(Value = "percent")]
        Percent,

        [EnumMember(Value = "dollar")]
        Dollar,

        [EnumMember(Value = "canadian_dollar")]
        CanadianDollar,

        [EnumMember(Value = "euro")]
        Euro,

        [EnumMember(Value = "pound")]
        Pound,

        [EnumMember(Value = "yen")]
        Yen,

        [EnumMember(Value = "ruble")]
        Ruble,

        [EnumMember(Value = "rupee")]
        Rupee,

        [EnumMember(Value = "won")]
        Won,

        [EnumMember(Value = "yuan")]
        Yuan,

        [EnumMember(Value = "real")]
        Real,

        [EnumMember(Value = "lira")]
        Lira,

        [EnumMember(Value = "rupiah")]
        Rupiah,

        [EnumMember(Value = "franc")]
        Franc,

        [EnumMember(Value = "hong_kong_dollar")]
        HongKongDollar,

        [EnumMember(Value = "new_zealand_dollar")]
        NewZealandDollar,

        [EnumMember(Value = "krona")]
        Krona,

        [EnumMember(Value = "norwegian_krone")]
        NorwegianKrone,

        [EnumMember(Value = "mexican_peso")]
        MexicanPeso,

        [EnumMember(Value = "rand")]
        Rand,

        [EnumMember(Value = "new_taiwan_dollar")]
        NewTaiwnaDollar,

        [EnumMember(Value = "danish_krone")]
        DanishKrone,

        [EnumMember(Value = "zloty")]
        Zloty,

        [EnumMember(Value = "baht")]
        Baht,

        [EnumMember(Value = "forint")]
        Forint,

        [EnumMember(Value = "koruna")]
        Koruna,

        [EnumMember(Value = "shekel")]
        Shekel,

        [EnumMember(Value = "chilean_peso")]
        ChileanPeso,

        [EnumMember(Value = "philippine_peso")]
        PhilippinePeso,

        [EnumMember(Value = "dirham")]
        Dirham,

        [EnumMember(Value = "colombian_peso")]
        ColombianPeso,

        [EnumMember(Value = "riyal")]
        Riyal,

        [EnumMember(Value = "ringgit")]
        Ringgit,

        [EnumMember(Value = "leu")]
        Leu,

        [EnumMember(Value = "argentine_peso")]
        ArgentinePeso,

        [EnumMember(Value = "uruguayan_peso")]
        UruguayanPeso,

        [EnumMember(Value = "singapore_dollar")]
        SignaporeDollar
    }
}
