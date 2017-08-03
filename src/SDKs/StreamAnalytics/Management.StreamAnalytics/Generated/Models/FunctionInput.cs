// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.StreamAnalytics.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.StreamAnalytics;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Describes one input parameter of a function.
    /// </summary>
    public partial class FunctionInput
    {
        /// <summary>
        /// Initializes a new instance of the FunctionInput class.
        /// </summary>
        public FunctionInput()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FunctionInput class.
        /// </summary>
        /// <param name="dataType">The (Azure Stream Analytics supported) data
        /// type of the function input parameter. A list of valid Azure Stream
        /// Analytics data types are described at
        /// https://msdn.microsoft.com/en-us/library/azure/dn835065.aspx</param>
        /// <param name="isConfigurationParameter">A flag indicating if the
        /// parameter is a configuration parameter. True if this input
        /// parameter is expected to be a constant. Default is false.</param>
        public FunctionInput(string dataType = default(string), bool? isConfigurationParameter = default(bool?))
        {
            DataType = dataType;
            IsConfigurationParameter = isConfigurationParameter;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the (Azure Stream Analytics supported) data type of
        /// the function input parameter. A list of valid Azure Stream
        /// Analytics data types are described at
        /// https://msdn.microsoft.com/en-us/library/azure/dn835065.aspx
        /// </summary>
        [JsonProperty(PropertyName = "dataType")]
        public string DataType { get; set; }

        /// <summary>
        /// Gets or sets a flag indicating if the parameter is a configuration
        /// parameter. True if this input parameter is expected to be a
        /// constant. Default is false.
        /// </summary>
        [JsonProperty(PropertyName = "isConfigurationParameter")]
        public bool? IsConfigurationParameter { get; set; }

    }
}