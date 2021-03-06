// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.StorSimple1200Series.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for AlertStatus.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AlertStatus
    {
        [EnumMember(Value = "Active")]
        Active,
        [EnumMember(Value = "Cleared")]
        Cleared
    }
    internal static class AlertStatusEnumExtension
    {
        internal static string ToSerializedValue(this AlertStatus? value)
        {
            return value == null ? null : ((AlertStatus)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this AlertStatus value)
        {
            switch( value )
            {
                case AlertStatus.Active:
                    return "Active";
                case AlertStatus.Cleared:
                    return "Cleared";
            }
            return null;
        }

        internal static AlertStatus? ParseAlertStatus(this string value)
        {
            switch( value )
            {
                case "Active":
                    return AlertStatus.Active;
                case "Cleared":
                    return AlertStatus.Cleared;
            }
            return null;
        }
    }
}
