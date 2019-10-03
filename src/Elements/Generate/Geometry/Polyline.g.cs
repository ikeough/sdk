//----------------------
// <auto-generated>
//     Generated using the NJsonSchema v10.0.24.0 (Newtonsoft.Json v9.0.0.0) (http://NJsonSchema.org)
// </auto-generated>
//----------------------

namespace Elements.Geometry
{
    #pragma warning disable // Disable all warnings

    using Elements.ElementTypes;
    using Elements.GeoJSON;
    using Elements.Geometry;
    using Elements.Geometry.Solids;
    using Elements.Properties;
    using System;
    using System.Collections.Generic;
    
    /// <summary>A coplanar continuous set of lines.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class Polyline : Curve
    {
        /// <summary>The vertices of the polygon.</summary>
        [Newtonsoft.Json.JsonProperty("Vertices", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.MinLength(2)]
        public  IList<Vector3> Vertices { get; internal set; } = new List<Vector3>();
    
    
    }
}