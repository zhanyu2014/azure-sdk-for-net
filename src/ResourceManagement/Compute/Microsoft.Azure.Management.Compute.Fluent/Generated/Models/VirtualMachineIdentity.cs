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
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Identity for the virtual machine.
    /// </summary>
    public partial class VirtualMachineIdentity
    {
        /// <summary>
        /// Initializes a new instance of the VirtualMachineIdentity class.
        /// </summary>
        public VirtualMachineIdentity()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VirtualMachineIdentity class.
        /// </summary>
        /// <param name="principalId">The principal id of virtual machine
        /// identity.</param>
        /// <param name="tenantId">The tenant id associated with the virtual
        /// machine.</param>
        /// <param name="type">The type of identity used for the virtual
        /// machine. Currently, the only supported type is 'SystemAssigned',
        /// which implicitly creates an identity. Possible values include:
        /// 'SystemAssigned'</param>
        public VirtualMachineIdentity(string principalId = default(string), string tenantId = default(string), ResourceIdentityType? type = default(ResourceIdentityType?))
        {
            PrincipalId = principalId;
            TenantId = tenantId;
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the principal id of virtual machine identity.
        /// </summary>
        [JsonProperty(PropertyName = "principalId")]
        public string PrincipalId { get; private set; }

        /// <summary>
        /// Gets the tenant id associated with the virtual machine.
        /// </summary>
        [JsonProperty(PropertyName = "tenantId")]
        public string TenantId { get; private set; }

        /// <summary>
        /// Gets or sets the type of identity used for the virtual machine.
        /// Currently, the only supported type is 'SystemAssigned', which
        /// implicitly creates an identity. Possible values include:
        /// 'SystemAssigned'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public ResourceIdentityType? Type { get; set; }

    }
}
