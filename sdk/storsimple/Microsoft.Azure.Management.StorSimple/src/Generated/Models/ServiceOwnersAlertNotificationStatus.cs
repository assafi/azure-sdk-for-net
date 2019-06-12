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
    /// Defines values for ServiceOwnersAlertNotificationStatus.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ServiceOwnersAlertNotificationStatus
    {
        [EnumMember(Value = "Enabled")]
        Enabled,
        [EnumMember(Value = "Disabled")]
        Disabled
    }
    internal static class ServiceOwnersAlertNotificationStatusEnumExtension
    {
        internal static string ToSerializedValue(this ServiceOwnersAlertNotificationStatus? value)
        {
            return value == null ? null : ((ServiceOwnersAlertNotificationStatus)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this ServiceOwnersAlertNotificationStatus value)
        {
            switch( value )
            {
                case ServiceOwnersAlertNotificationStatus.Enabled:
                    return "Enabled";
                case ServiceOwnersAlertNotificationStatus.Disabled:
                    return "Disabled";
            }
            return null;
        }

        internal static ServiceOwnersAlertNotificationStatus? ParseServiceOwnersAlertNotificationStatus(this string value)
        {
            switch( value )
            {
                case "Enabled":
                    return ServiceOwnersAlertNotificationStatus.Enabled;
                case "Disabled":
                    return ServiceOwnersAlertNotificationStatus.Disabled;
            }
            return null;
        }
    }
}