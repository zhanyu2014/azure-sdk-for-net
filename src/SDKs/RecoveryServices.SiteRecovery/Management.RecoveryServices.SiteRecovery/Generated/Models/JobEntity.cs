// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// This class contains the minimal job details required to navigate to the
    /// desired drill down.
    /// </summary>
    public partial class JobEntity
    {
        /// <summary>
        /// Initializes a new instance of the JobEntity class.
        /// </summary>
        public JobEntity()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the JobEntity class.
        /// </summary>
        /// <param name="jobId">The job id.</param>
        /// <param name="jobFriendlyName">The job display name.</param>
        /// <param name="targetObjectId">The object id.</param>
        /// <param name="targetObjectName">The object name.</param>
        /// <param name="targetInstanceType">The workflow affected object
        /// type.</param>
        /// <param name="jobScenarioName">The job name. Enum type
        /// ScenarioName.</param>
        public JobEntity(string jobId = default(string), string jobFriendlyName = default(string), string targetObjectId = default(string), string targetObjectName = default(string), string targetInstanceType = default(string), string jobScenarioName = default(string))
        {
            JobId = jobId;
            JobFriendlyName = jobFriendlyName;
            TargetObjectId = targetObjectId;
            TargetObjectName = targetObjectName;
            TargetInstanceType = targetInstanceType;
            JobScenarioName = jobScenarioName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the job id.
        /// </summary>
        [JsonProperty(PropertyName = "jobId")]
        public string JobId { get; set; }

        /// <summary>
        /// Gets or sets the job display name.
        /// </summary>
        [JsonProperty(PropertyName = "jobFriendlyName")]
        public string JobFriendlyName { get; set; }

        /// <summary>
        /// Gets or sets the object id.
        /// </summary>
        [JsonProperty(PropertyName = "targetObjectId")]
        public string TargetObjectId { get; set; }

        /// <summary>
        /// Gets or sets the object name.
        /// </summary>
        [JsonProperty(PropertyName = "targetObjectName")]
        public string TargetObjectName { get; set; }

        /// <summary>
        /// Gets or sets the workflow affected object type.
        /// </summary>
        [JsonProperty(PropertyName = "targetInstanceType")]
        public string TargetInstanceType { get; set; }

        /// <summary>
        /// Gets or sets the job name. Enum type ScenarioName.
        /// </summary>
        [JsonProperty(PropertyName = "jobScenarioName")]
        public string JobScenarioName { get; set; }

    }
}
