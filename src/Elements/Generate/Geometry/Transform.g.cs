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
    
    /// <summary>A transform.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class Transform 
    {
        /// <summary>The origin.</summary>
        [Newtonsoft.Json.JsonProperty("Origin", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public  Vector3 Origin { get; internal set; } = new Vector3();
    
        /// <summary>The X axis.</summary>
        [Newtonsoft.Json.JsonProperty("XAxis", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public  Vector3 XAxis { get; internal set; } = new Vector3();
    
        /// <summary>The Y axis.</summary>
        [Newtonsoft.Json.JsonProperty("YAxis", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public  Vector3 YAxis { get; internal set; } = new Vector3();
    
        /// <summary>The Z axis.</summary>
        [Newtonsoft.Json.JsonProperty("ZAxis", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public  Vector3 ZAxis { get; internal set; } = new Vector3();
    
    
    }
}