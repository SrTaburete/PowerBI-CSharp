// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.PowerBI.Api.V1.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    /// <summary>
    /// A Power BI gateway datasource
    /// </summary>
    public partial class GatewayDatasource
    {
        /// <summary>
        /// Initializes a new instance of the GatewayDatasource class.
        /// </summary>
        public GatewayDatasource() { }

        /// <summary>
        /// Initializes a new instance of the GatewayDatasource class.
        /// </summary>
        public GatewayDatasource(string id = default(string), string gatewayId = default(string), string datasourceType = default(string), string connectionDetails = default(string), string credentialType = default(string), BasicCredentials basicCredentials = default(BasicCredentials))
        {
            Id = id;
            GatewayId = gatewayId;
            DatasourceType = datasourceType;
            ConnectionDetails = connectionDetails;
            CredentialType = credentialType;
            BasicCredentials = basicCredentials;
        }

        /// <summary>
        /// The unique id for this gateway datasource
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// The associated gateway id
        /// </summary>
        [JsonProperty(PropertyName = "gatewayId")]
        public string GatewayId { get; set; }

        /// <summary>
        /// The datasource type
        /// </summary>
        [JsonProperty(PropertyName = "datasourceType")]
        public string DatasourceType { get; set; }

        /// <summary>
        /// The datasource connection details
        /// </summary>
        [JsonProperty(PropertyName = "connectionDetails")]
        public string ConnectionDetails { get; set; }

        /// <summary>
        /// The datasource credential type
        /// </summary>
        [JsonProperty(PropertyName = "credentialType")]
        public string CredentialType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "basicCredentials")]
        public BasicCredentials BasicCredentials { get; set; }

    }
}
