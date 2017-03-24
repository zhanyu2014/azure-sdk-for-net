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
    /// Container service.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ContainerServiceInner : Microsoft.Azure.Management.ResourceManager.Fluent.Resource
    {
        /// <summary>
        /// Initializes a new instance of the ContainerServiceInner class.
        /// </summary>
        public ContainerServiceInner()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ContainerServiceInner class.
        /// </summary>
        /// <param name="masterProfile">Properties of master agents.</param>
        /// <param name="agentPoolProfiles">Properties of the agent
        /// pool.</param>
        /// <param name="linuxProfile">Properties of Linux VMs.</param>
        /// <param name="provisioningState">the current deployment or
        /// provisioning state, which only appears in the response.</param>
        /// <param name="orchestratorProfile">Properties of the
        /// orchestrator.</param>
        /// <param name="customProfile">Properties for custom clusters.</param>
        /// <param name="servicePrincipalProfile">Properties for cluster
        /// service principals.</param>
        /// <param name="windowsProfile">Properties of Windows VMs.</param>
        /// <param name="diagnosticsProfile">Properties of the diagnostic
        /// agent.</param>
        public ContainerServiceInner(ContainerServiceMasterProfile masterProfile, IList<ContainerServiceAgentPoolProfile> agentPoolProfiles, ContainerServiceLinuxProfile linuxProfile, string location = default(string), string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string provisioningState = default(string), ContainerServiceOrchestratorProfile orchestratorProfile = default(ContainerServiceOrchestratorProfile), ContainerServiceCustomProfile customProfile = default(ContainerServiceCustomProfile), ContainerServiceServicePrincipalProfile servicePrincipalProfile = default(ContainerServiceServicePrincipalProfile), ContainerServiceWindowsProfile windowsProfile = default(ContainerServiceWindowsProfile), ContainerServiceDiagnosticsProfile diagnosticsProfile = default(ContainerServiceDiagnosticsProfile))
            : base(location, id, name, type, tags)
        {
            ProvisioningState = provisioningState;
            OrchestratorProfile = orchestratorProfile;
            CustomProfile = customProfile;
            ServicePrincipalProfile = servicePrincipalProfile;
            MasterProfile = masterProfile;
            AgentPoolProfiles = agentPoolProfiles;
            WindowsProfile = windowsProfile;
            LinuxProfile = linuxProfile;
            DiagnosticsProfile = diagnosticsProfile;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the current deployment or provisioning state, which only
        /// appears in the response.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets properties of the orchestrator.
        /// </summary>
        [JsonProperty(PropertyName = "properties.orchestratorProfile")]
        public ContainerServiceOrchestratorProfile OrchestratorProfile { get; set; }

        /// <summary>
        /// Gets or sets properties for custom clusters.
        /// </summary>
        [JsonProperty(PropertyName = "properties.customProfile")]
        public ContainerServiceCustomProfile CustomProfile { get; set; }

        /// <summary>
        /// Gets or sets properties for cluster service principals.
        /// </summary>
        [JsonProperty(PropertyName = "properties.servicePrincipalProfile")]
        public ContainerServiceServicePrincipalProfile ServicePrincipalProfile { get; set; }

        /// <summary>
        /// Gets or sets properties of master agents.
        /// </summary>
        [JsonProperty(PropertyName = "properties.masterProfile")]
        public ContainerServiceMasterProfile MasterProfile { get; set; }

        /// <summary>
        /// Gets or sets properties of the agent pool.
        /// </summary>
        [JsonProperty(PropertyName = "properties.agentPoolProfiles")]
        public IList<ContainerServiceAgentPoolProfile> AgentPoolProfiles { get; set; }

        /// <summary>
        /// Gets or sets properties of Windows VMs.
        /// </summary>
        [JsonProperty(PropertyName = "properties.windowsProfile")]
        public ContainerServiceWindowsProfile WindowsProfile { get; set; }

        /// <summary>
        /// Gets or sets properties of Linux VMs.
        /// </summary>
        [JsonProperty(PropertyName = "properties.linuxProfile")]
        public ContainerServiceLinuxProfile LinuxProfile { get; set; }

        /// <summary>
        /// Gets or sets properties of the diagnostic agent.
        /// </summary>
        [JsonProperty(PropertyName = "properties.diagnosticsProfile")]
        public ContainerServiceDiagnosticsProfile DiagnosticsProfile { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (MasterProfile == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "MasterProfile");
            }
            if (AgentPoolProfiles == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AgentPoolProfiles");
            }
            if (LinuxProfile == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "LinuxProfile");
            }
            if (OrchestratorProfile != null)
            {
                OrchestratorProfile.Validate();
            }
            if (CustomProfile != null)
            {
                CustomProfile.Validate();
            }
            if (ServicePrincipalProfile != null)
            {
                ServicePrincipalProfile.Validate();
            }
            if (MasterProfile != null)
            {
                MasterProfile.Validate();
            }
            if (AgentPoolProfiles != null)
            {
                foreach (var element in AgentPoolProfiles)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (WindowsProfile != null)
            {
                WindowsProfile.Validate();
            }
            if (LinuxProfile != null)
            {
                LinuxProfile.Validate();
            }
            if (DiagnosticsProfile != null)
            {
                DiagnosticsProfile.Validate();
            }
        }
    }
}
