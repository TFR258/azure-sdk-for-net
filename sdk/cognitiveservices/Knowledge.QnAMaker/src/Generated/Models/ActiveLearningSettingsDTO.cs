// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Knowledge.QnAMaker.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Active Learning settings of the endpoint.
    /// </summary>
    public partial class ActiveLearningSettingsDTO
    {
        /// <summary>
        /// Initializes a new instance of the ActiveLearningSettingsDTO class.
        /// </summary>
        public ActiveLearningSettingsDTO()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ActiveLearningSettingsDTO class.
        /// </summary>
        /// <param name="enable">True/False string providing Active
        /// Learning</param>
        public ActiveLearningSettingsDTO(string enable = default(string))
        {
            Enable = enable;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets true/False string providing Active Learning
        /// </summary>
        [JsonProperty(PropertyName = "enable")]
        public string Enable { get; set; }

    }
}