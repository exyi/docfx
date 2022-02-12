// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.DocAsCode.DataContracts.Common
{
    using System;

    using Newtonsoft.Json;
    using YamlDotNet.Serialization;

    using Microsoft.DocAsCode.Common.Git;
	using System.ComponentModel;

	[Serializable]
    public class SourceDetail
    {
        [YamlMember(Alias = "remote")]
        [JsonProperty("remote")]
        public GitDetail Remote { get; set; }

        [YamlMember(Alias = "base")]
        [JsonProperty("base")]
        public string BasePath { get; set; }

        [YamlMember(Alias = "id")]
        [JsonProperty("id")]
        public string Name { get; set; }

        /// <summary>
        /// The url path for current source, should be resolved at some late stage
        /// </summary>
        [YamlMember(Alias = Constants.PropertyName.Href)]
        [JsonProperty(Constants.PropertyName.Href)]
        public string Href { get; set; }

        /// <summary>
        /// The local path for current source, should be resolved to be relative path at some late stage
        /// </summary>
        [YamlMember(Alias = "path")]
        [JsonProperty("path")]
        public string Path { get; set; }

        [YamlMember(Alias = "startLine")]
        [JsonProperty("startLine")]
        [DefaultValue(0)]
        public int StartLine { get; set; }

        [YamlMember(Alias = "endLine")]
        [JsonProperty("endLine")]
        [DefaultValue(0)]
        public int EndLine { get; set; }

        [YamlMember(Alias = "content")]
        [JsonProperty("content")]
        public string Content { get; set; }

        /// <summary>
        /// The external path for current source if it is not locally available
        /// </summary>
        [YamlMember(Alias = "isExternal")]
        [JsonProperty("isExternal")]
        [DefaultValue(false)]
        public bool IsExternalPath { get; set; }
    }
}
