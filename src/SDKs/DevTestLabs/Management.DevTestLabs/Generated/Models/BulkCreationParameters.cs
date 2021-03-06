// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DevTestLabs.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Parameters for creating multiple virtual machines as a single action.
    /// </summary>
    public partial class BulkCreationParameters
    {
        /// <summary>
        /// Initializes a new instance of the BulkCreationParameters class.
        /// </summary>
        public BulkCreationParameters() { }

        /// <summary>
        /// Initializes a new instance of the BulkCreationParameters class.
        /// </summary>
        public BulkCreationParameters(int? instanceCount = default(int?))
        {
            InstanceCount = instanceCount;
        }

        /// <summary>
        /// The number of virtual machine instances to create.
        /// </summary>
        [JsonProperty(PropertyName = "instanceCount")]
        public int? InstanceCount { get; set; }

    }
}
