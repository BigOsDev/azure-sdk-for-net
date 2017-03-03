// Copyright (c) Microsoft and contributors.  All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//
// See the License for the specific language governing permissions and
// limitations under the License.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using System.Linq;

    /// <summary>
    /// Contains information about an application in an Azure Batch account.
    /// </summary>
    public partial class ApplicationSummary
    {
        /// <summary>
        /// Initializes a new instance of the ApplicationSummary class.
        /// </summary>
        public ApplicationSummary() { }

        /// <summary>
        /// Initializes a new instance of the ApplicationSummary class.
        /// </summary>
        /// <param name="id">A string that uniquely identifies the application
        /// within the account.</param>
        /// <param name="displayName">The display name for the
        /// application.</param>
        /// <param name="versions">The versions of the application which are
        /// available.</param>
        public ApplicationSummary(string id, string displayName, System.Collections.Generic.IList<string> versions)
        {
            Id = id;
            DisplayName = displayName;
            Versions = versions;
        }

        /// <summary>
        /// Gets or sets a string that uniquely identifies the application
        /// within the account.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the display name for the application.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the versions of the application which are available.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "versions")]
        public System.Collections.Generic.IList<string> Versions { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Id == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Id");
            }
            if (DisplayName == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "DisplayName");
            }
            if (Versions == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Versions");
            }
        }
    }
}