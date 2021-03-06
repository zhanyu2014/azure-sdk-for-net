// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataLake.Analytics.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Data Lake Analytics Job Parameters base class for build and submit.
    /// </summary>
    public partial class BaseJobParameters
    {
        /// <summary>
        /// Initializes a new instance of the BaseJobParameters class.
        /// </summary>
        public BaseJobParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BaseJobParameters class.
        /// </summary>
        /// <param name="type">the job type of the current job (Hive, USql, or
        /// Scope (for internal use only)). Possible values include: 'USql',
        /// 'Hive', 'Scope'</param>
        /// <param name="properties">the job specific properties.</param>
        public BaseJobParameters(JobType type, CreateJobProperties properties)
        {
            Type = type;
            Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the job type of the current job (Hive, USql, or Scope
        /// (for internal use only)). Possible values include: 'USql', 'Hive',
        /// 'Scope'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public JobType Type { get; set; }

        /// <summary>
        /// Gets or sets the job specific properties.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public CreateJobProperties Properties { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Properties == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Properties");
            }
            if (Properties != null)
            {
                Properties.Validate();
            }
        }
    }
}
