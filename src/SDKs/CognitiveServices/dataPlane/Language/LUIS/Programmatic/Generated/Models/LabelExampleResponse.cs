// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Language.LUIS.Programmatic.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Response when adding a labeled example.
    /// </summary>
    public partial class LabelExampleResponse
    {
        /// <summary>
        /// Initializes a new instance of the LabelExampleResponse class.
        /// </summary>
        public LabelExampleResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LabelExampleResponse class.
        /// </summary>
        /// <param name="utteranceText">The sample's utterance.</param>
        /// <param name="exampleId">The newly created sample ID.</param>
        public LabelExampleResponse(string utteranceText = default(string), int? exampleId = default(int?))
        {
            UtteranceText = utteranceText;
            ExampleId = exampleId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the sample's utterance.
        /// </summary>
        [JsonProperty(PropertyName = "UtteranceText")]
        public string UtteranceText { get; set; }

        /// <summary>
        /// Gets or sets the newly created sample ID.
        /// </summary>
        [JsonProperty(PropertyName = "ExampleId")]
        public int? ExampleId { get; set; }

    }
}
