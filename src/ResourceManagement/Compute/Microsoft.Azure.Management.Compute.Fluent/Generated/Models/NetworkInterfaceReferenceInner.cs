// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Compute;
    using Microsoft.Azure.Management.Compute.Fluent;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Describes a network interface reference.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class NetworkInterfaceReferenceInner : Microsoft.Azure.Management.ResourceManager.Fluent.SubResource
    {
        /// <summary>
        /// Initializes a new instance of the NetworkInterfaceReferenceInner
        /// class.
        /// </summary>
        public NetworkInterfaceReferenceInner()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the NetworkInterfaceReferenceInner
        /// class.
        /// </summary>
        /// <param name="primary">Specifies the primary network interface in
        /// case the virtual machine has more than 1 network interface.</param>
        public NetworkInterfaceReferenceInner(string id = default(string), bool? primary = default(bool?))
            : base(id)
        {
            Primary = primary;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets specifies the primary network interface in case the
        /// virtual machine has more than 1 network interface.
        /// </summary>
        [JsonProperty(PropertyName = "properties.primary")]
        public bool? Primary { get; set; }

    }
}
