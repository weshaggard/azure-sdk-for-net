// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Maps.Weather.Models
{
    /// <summary> Wind direction. </summary>
    public partial class WindDirection
    {
        /// <summary> Initializes a new instance of <see cref="WindDirection"/>. </summary>
        internal WindDirection()
        {
        }

        /// <summary> Initializes a new instance of <see cref="WindDirection"/>. </summary>
        /// <param name="degrees"> Wind direction in Azimuth degrees,  starting at true North and continuing in clockwise direction. North is 0 degrees, east is 90 degrees, south is 180 degrees, west is 270 degrees. Possible values 0-359. </param>
        /// <param name="description"> Direction abbreviation in the specified language. </param>
        internal WindDirection(int? degrees, string description)
        {
            Degrees = degrees;
            Description = description;
        }

        /// <summary> Wind direction in Azimuth degrees,  starting at true North and continuing in clockwise direction. North is 0 degrees, east is 90 degrees, south is 180 degrees, west is 270 degrees. Possible values 0-359. </summary>
        public int? Degrees { get; }
        /// <summary> Direction abbreviation in the specified language. </summary>
        public string Description { get; }
    }
}
