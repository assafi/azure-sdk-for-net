// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Billing.Models
{
    using Azure;
    using Management;
    using Billing;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The object that represents the operation.
    /// </summary>
    public partial class OperationDisplay
    {
        /// <summary>
        /// Initializes a new instance of the OperationDisplay class.
        /// </summary>
        public OperationDisplay() { }

        /// <summary>
        /// Initializes a new instance of the OperationDisplay class.
        /// </summary>
        /// <param name="provider">Service provider: Microsoft.Billing</param>
        /// <param name="resource">Resource on which the operation is
        /// performed: Invoice, etc.</param>
        /// <param name="operation">Operation type: Read, write, delete,
        /// etc.</param>
        public OperationDisplay(string provider = default(string), string resource = default(string), string operation = default(string))
        {
            Provider = provider;
            Resource = resource;
            Operation = operation;
        }

        /// <summary>
        /// Gets service provider: Microsoft.Billing
        /// </summary>
        [JsonProperty(PropertyName = "provider")]
        public string Provider { get; protected set; }

        /// <summary>
        /// Gets resource on which the operation is performed: Invoice, etc.
        /// </summary>
        [JsonProperty(PropertyName = "resource")]
        public string Resource { get; protected set; }

        /// <summary>
        /// Gets operation type: Read, write, delete, etc.
        /// </summary>
        [JsonProperty(PropertyName = "operation")]
        public string Operation { get; protected set; }

    }
}
