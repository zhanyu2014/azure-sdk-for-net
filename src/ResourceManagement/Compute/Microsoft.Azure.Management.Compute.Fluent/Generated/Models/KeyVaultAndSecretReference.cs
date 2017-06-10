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
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Key Vault Secret Url and vault id of the encryption key
    /// </summary>
    public partial class KeyVaultAndSecretReference
    {
        /// <summary>
        /// Initializes a new instance of the KeyVaultAndSecretReference class.
        /// </summary>
        public KeyVaultAndSecretReference()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the KeyVaultAndSecretReference class.
        /// </summary>
        /// <param name="sourceVault">Resource id of the KeyVault containing
        /// the key or secret</param>
        /// <param name="secretUrl">Url pointing to a key or secret in
        /// KeyVault</param>
        public KeyVaultAndSecretReference(SourceVault sourceVault, string secretUrl)
        {
            SourceVault = sourceVault;
            SecretUrl = secretUrl;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets resource id of the KeyVault containing the key or
        /// secret
        /// </summary>
        [JsonProperty(PropertyName = "sourceVault")]
        public SourceVault SourceVault { get; set; }

        /// <summary>
        /// Gets or sets url pointing to a key or secret in KeyVault
        /// </summary>
        [JsonProperty(PropertyName = "secretUrl")]
        public string SecretUrl { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (SourceVault == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SourceVault");
            }
            if (SecretUrl == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SecretUrl");
            }
        }
    }
}