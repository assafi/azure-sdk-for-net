// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Blueprint.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Defines how resources deployed by a blueprint assignment are locked.
    /// </summary>
    public partial class AssignmentLockSettings
    {
        /// <summary>
        /// Initializes a new instance of the AssignmentLockSettings class.
        /// </summary>
        public AssignmentLockSettings()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AssignmentLockSettings class.
        /// </summary>
        /// <param name="mode">Lock mode. Possible values include: 'None',
        /// 'AllResourcesReadOnly', 'AllResourcesDoNotDelete'</param>
        public AssignmentLockSettings(string mode = default(string))
        {
            Mode = mode;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets lock mode. Possible values include: 'None',
        /// 'AllResourcesReadOnly', 'AllResourcesDoNotDelete'
        /// </summary>
        [JsonProperty(PropertyName = "mode")]
        public string Mode { get; set; }

    }
}