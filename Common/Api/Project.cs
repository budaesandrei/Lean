/*
 * QUANTCONNECT.COM - Democratizing Finance, Empowering Individuals.
 * Lean Algorithmic Trading Engine v2.0. Copyright 2014 QuantConnect Corporation.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License"); 
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
*/
using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace QuantConnect.Api
{
    /// <summary>
    /// Response from reading a project by id.
    /// </summary>
    public class Project : RestResponse
    {
        /// <summary>
        /// Project id
        /// </summary>
        [JsonProperty(PropertyName = "projectId")]
        public int ProjectId { get; set; }

        /// <summary>
        /// Name of the project
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Date the project was created
        /// </summary>
        [JsonProperty(PropertyName = "created")]
        public DateTime Created { get; set; }

        /// <summary>
        /// Modified date for the project
        /// </summary>
        [JsonProperty(PropertyName = "modified")]
        public DateTime Modified { get; set; }

        /// <summary>
        /// Programming language of the project
        /// </summary>
        [JsonProperty(PropertyName = "language")]
        public Language Language { get; set; }

        /// <summary>
        /// The projects owner id
        /// </summary>
        [JsonProperty(PropertyName = "ownerId")]
        public int OwnerId { get; set; }
    }

    /// <summary>
    /// Project list response
    /// </summary>
    public class ProjectResponse : RestResponse
    {
        /// <summary>
        /// List of projects for the authenticated user
        /// </summary>
        [JsonProperty(PropertyName = "projects")]
        public List<Project> Projects { get; set; }
    }
}
