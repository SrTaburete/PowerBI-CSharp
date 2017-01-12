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
    /// Odata response wrapper for a Power BI datasource collection
    /// </summary>
    public partial class ODataResponseListDatasource
    {
        /// <summary>
        /// Initializes a new instance of the ODataResponseListDatasource
        /// class.
        /// </summary>
        public ODataResponseListDatasource() { }

        /// <summary>
        /// Initializes a new instance of the ODataResponseListDatasource
        /// class.
        /// </summary>
        public ODataResponseListDatasource(string odatacontext = default(string), IList<Datasource> value = default(IList<Datasource>))
        {
            Odatacontext = odatacontext;
            Value = value;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "odata.context")]
        public string Odatacontext { get; set; }

        /// <summary>
        /// The datasource collection
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<Datasource> Value { get; set; }

    }
}
