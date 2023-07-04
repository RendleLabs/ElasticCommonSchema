namespace ElasticCommonSchema;

public static partial class ECS
{
    public static partial class Host
    {
        public static partial class Geo
        {
            /// <summary>
            /// City name.
            /// </summary>
            /// <example>
            /// <c>Montreal</c>
            /// </example>
            public const string CityName = "host.geo.city_name";
            
            /// <summary>
            /// Continent code.
            /// </summary>
            /// <example>
            /// <c>NA</c>
            /// </example>
            public const string ContinentCode = "host.geo.continent_code";
            
            /// <summary>
            /// Name of the continent.
            /// </summary>
            /// <example>
            /// <c>North America</c>
            /// </example>
            public const string ContinentName = "host.geo.continent_name";
            
            /// <summary>
            /// Country ISO code.
            /// </summary>
            /// <example>
            /// <c>CA</c>
            /// </example>
            public const string CountryIsoCode = "host.geo.country_iso_code";
            
            /// <summary>
            /// Country name.
            /// </summary>
            /// <example>
            /// <c>Canada</c>
            /// </example>
            public const string CountryName = "host.geo.country_name";
            
            /// <summary>
            /// Longitude and latitude.
            /// </summary>
            /// <example>
            /// <c>{ "lon": -73.614830, "lat": 45.505918 }</c>
            /// </example>
            public const string Location = "host.geo.location";
            
            /// <summary>
            /// User-defined description of a location.
            /// </summary>
            /// <example>
            /// <c>boston-dc</c>
            /// </example>
            public const string Name = "host.geo.name";
            
            /// <summary>
            /// Postal code.
            /// </summary>
            /// <example>
            /// <c>94040</c>
            /// </example>
            public const string PostalCode = "host.geo.postal_code";
            
            /// <summary>
            /// Region ISO code.
            /// </summary>
            /// <example>
            /// <c>CA-QC</c>
            /// </example>
            public const string RegionIsoCode = "host.geo.region_iso_code";
            
            /// <summary>
            /// Region name.
            /// </summary>
            /// <example>
            /// <c>Quebec</c>
            /// </example>
            public const string RegionName = "host.geo.region_name";
            
            /// <summary>
            /// Time zone.
            /// </summary>
            /// <example>
            /// <c>America/Argentina/Buenos_Aires</c>
            /// </example>
            public const string Timezone = "host.geo.timezone";
            
        }
    }
}

