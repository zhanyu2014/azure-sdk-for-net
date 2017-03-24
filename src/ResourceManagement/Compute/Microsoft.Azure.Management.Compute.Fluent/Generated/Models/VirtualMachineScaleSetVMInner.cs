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
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Describes a virtual machine scale set virtual machine.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class VirtualMachineScaleSetVMInner : Microsoft.Azure.Management.ResourceManager.Fluent.Resource
    {
        /// <summary>
        /// Initializes a new instance of the VirtualMachineScaleSetVMInner
        /// class.
        /// </summary>
        public VirtualMachineScaleSetVMInner()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VirtualMachineScaleSetVMInner
        /// class.
        /// </summary>
        /// <param name="instanceId">The virtual machine instance ID.</param>
        /// <param name="sku">The virtual machine SKU.</param>
        /// <param name="latestModelApplied">Specifies whether the latest model
        /// has been applied to the virtual machine.</param>
        /// <param name="vmId">Azure VM unique ID.</param>
        /// <param name="instanceView">The virtual machine instance
        /// view.</param>
        /// <param name="hardwareProfile">The hardware profile.</param>
        /// <param name="storageProfile">The storage profile.</param>
        /// <param name="osProfile">The OS profile.</param>
        /// <param name="networkProfile">The network profile.</param>
        /// <param name="diagnosticsProfile">The diagnostics profile.</param>
        /// <param name="availabilitySet">The reference Id of the availability
        /// set to which this virtual machine belongs.</param>
        /// <param name="provisioningState">The provisioning state, which only
        /// appears in the response.</param>
        /// <param name="licenseType">The license type, which is for bring your
        /// own license scenario.</param>
        /// <param name="plan">The purchase plan when deploying virtual machine
        /// from VM Marketplace images.</param>
        /// <param name="resources">The virtual machine child extension
        /// resources.</param>
        public VirtualMachineScaleSetVMInner(string location = default(string), string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string instanceId = default(string), Sku sku = default(Sku), bool? latestModelApplied = default(bool?), string vmId = default(string), VirtualMachineInstanceView instanceView = default(VirtualMachineInstanceView), HardwareProfile hardwareProfile = default(HardwareProfile), StorageProfile storageProfile = default(StorageProfile), OSProfile osProfile = default(OSProfile), NetworkProfile networkProfile = default(NetworkProfile), DiagnosticsProfile diagnosticsProfile = default(DiagnosticsProfile), Microsoft.Azure.Management.ResourceManager.Fluent.SubResource availabilitySet = default(Microsoft.Azure.Management.ResourceManager.Fluent.SubResource), string provisioningState = default(string), string licenseType = default(string), Plan plan = default(Plan), IList<VirtualMachineExtensionInner> resources = default(IList<VirtualMachineExtensionInner>))
            : base(location, id, name, type, tags)
        {
            InstanceId = instanceId;
            Sku = sku;
            LatestModelApplied = latestModelApplied;
            VmId = vmId;
            InstanceView = instanceView;
            HardwareProfile = hardwareProfile;
            StorageProfile = storageProfile;
            OsProfile = osProfile;
            NetworkProfile = networkProfile;
            DiagnosticsProfile = diagnosticsProfile;
            AvailabilitySet = availabilitySet;
            ProvisioningState = provisioningState;
            LicenseType = licenseType;
            Plan = plan;
            Resources = resources;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the virtual machine instance ID.
        /// </summary>
        [JsonProperty(PropertyName = "instanceId")]
        public string InstanceId { get; private set; }

        /// <summary>
        /// Gets the virtual machine SKU.
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public Sku Sku { get; private set; }

        /// <summary>
        /// Gets specifies whether the latest model has been applied to the
        /// virtual machine.
        /// </summary>
        [JsonProperty(PropertyName = "properties.latestModelApplied")]
        public bool? LatestModelApplied { get; private set; }

        /// <summary>
        /// Gets azure VM unique ID.
        /// </summary>
        [JsonProperty(PropertyName = "properties.vmId")]
        public string VmId { get; private set; }

        /// <summary>
        /// Gets the virtual machine instance view.
        /// </summary>
        [JsonProperty(PropertyName = "properties.instanceView")]
        public VirtualMachineInstanceView InstanceView { get; private set; }

        /// <summary>
        /// Gets or sets the hardware profile.
        /// </summary>
        [JsonProperty(PropertyName = "properties.hardwareProfile")]
        public HardwareProfile HardwareProfile { get; set; }

        /// <summary>
        /// Gets or sets the storage profile.
        /// </summary>
        [JsonProperty(PropertyName = "properties.storageProfile")]
        public StorageProfile StorageProfile { get; set; }

        /// <summary>
        /// Gets or sets the OS profile.
        /// </summary>
        [JsonProperty(PropertyName = "properties.osProfile")]
        public OSProfile OsProfile { get; set; }

        /// <summary>
        /// Gets or sets the network profile.
        /// </summary>
        [JsonProperty(PropertyName = "properties.networkProfile")]
        public NetworkProfile NetworkProfile { get; set; }

        /// <summary>
        /// Gets or sets the diagnostics profile.
        /// </summary>
        [JsonProperty(PropertyName = "properties.diagnosticsProfile")]
        public DiagnosticsProfile DiagnosticsProfile { get; set; }

        /// <summary>
        /// Gets or sets the reference Id of the availability set to which this
        /// virtual machine belongs.
        /// </summary>
        [JsonProperty(PropertyName = "properties.availabilitySet")]
        public Microsoft.Azure.Management.ResourceManager.Fluent.SubResource AvailabilitySet { get; set; }

        /// <summary>
        /// Gets the provisioning state, which only appears in the response.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets the license type, which is for bring your own license
        /// scenario.
        /// </summary>
        [JsonProperty(PropertyName = "properties.licenseType")]
        public string LicenseType { get; set; }

        /// <summary>
        /// Gets or sets the purchase plan when deploying virtual machine from
        /// VM Marketplace images.
        /// </summary>
        [JsonProperty(PropertyName = "plan")]
        public Plan Plan { get; set; }

        /// <summary>
        /// Gets the virtual machine child extension resources.
        /// </summary>
        [JsonProperty(PropertyName = "resources")]
        public IList<VirtualMachineExtensionInner> Resources { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (StorageProfile != null)
            {
                StorageProfile.Validate();
            }
        }
    }
}
