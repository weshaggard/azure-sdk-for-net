// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Maps.Common;

namespace Azure.Maps.Search.Models
{
    internal partial class GeoJsonGeometry
    {
        internal static GeoJsonGeometry DeserializeGeoJsonGeometry(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "GeometryCollection": return GeoJsonGeometryCollection.DeserializeGeoJsonGeometryCollection(element);
                    case "LineString": return GeoJsonLineString.DeserializeGeoJsonLineString(element);
                    case "MultiLineString": return GeoJsonMultiLineString.DeserializeGeoJsonMultiLineString(element);
                    case "MultiPoint": return GeoJsonMultiPoint.DeserializeGeoJsonMultiPoint(element);
                    case "MultiPolygon": return GeoJsonMultiPolygon.DeserializeGeoJsonMultiPolygon(element);
                    case "Point": return GeoJsonPoint.DeserializeGeoJsonPoint(element);
                    case "Polygon": return GeoJsonPolygon.DeserializeGeoJsonPolygon(element);
                }
            }
            GeoJsonObjectType type = "GeoJsonGeometry";
            IReadOnlyList<double> bbox = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = new GeoJsonObjectType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("bbox"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<double> array = new List<double>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetDouble());
                    }
                    bbox = array;
                    continue;
                }
            }
            return new GeoJsonGeometry(type, bbox ?? new ChangeTrackingList<double>());
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new GeoJsonGeometry FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeGeoJsonGeometry(document.RootElement);
        }
    }
}
