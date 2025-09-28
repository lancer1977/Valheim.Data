using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Polyhydra.Valheim.Api.Models
{


    public static class Position
    {
        public static PositionType Default() => new PositionType(0, 0, 0);
        public static PositionType Create(double x, double y, double z) => new PositionType((float)x, (float)y, (float)z);

         

        private static readonly Regex PositionRegex = new(
            @"^\s*\((-?\d+(\.\d+)?),\s*(-?\d+(\.\d+)?),\s*(-?\d+(\.\d+)?)\)\s*(\((-?\d+),\s*(-?\d+)\))?\s*$",
            RegexOptions.Compiled
        );

        public static PositionType Create(string value)
        {
            var match = PositionRegex.Match(value);
            if (!match.Success)
                throw new Exception($"Invalid position format: {value}");

            // World position
            var x = float.Parse(match.Groups[1].Value, CultureInfo.InvariantCulture);
            var y = float.Parse(match.Groups[5].Value, CultureInfo.InvariantCulture);
            var z = float.Parse(match.Groups[3].Value, CultureInfo.InvariantCulture);

            // Zone (optional)
            int? zoneX = null, zoneY = null;
            if (match.Groups[8].Success && match.Groups[9].Success)
            {
                zoneX = int.Parse(match.Groups[8].Value, CultureInfo.InvariantCulture);
                zoneY = int.Parse(match.Groups[9].Value, CultureInfo.InvariantCulture);
            }

            return new PositionType(x, y, z, zoneX, zoneY);
        }
    }

} 