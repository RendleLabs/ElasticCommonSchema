namespace ElasticCommonSchema;

public static partial class ECS
{
    public static partial class Threat
    {
        public static partial class Indicator
        {
            public static partial class Geo
            {
                /// <summary>
                /// City name.
                /// </summary>
                /// <example>
                /// <c>Montreal</c>
                /// </example>
                public const string CityName = "threat.indicator.geo.city_name";
                
                /// <summary>
                /// Continent code.
                /// </summary>
                /// <example>
                /// <c>NA</c>
                /// </example>
                public const string ContinentCode = "threat.indicator.geo.continent_code";
                
                /// <summary>
                /// Name of the continent.
                /// </summary>
                /// <example>
                /// <c>North America</c>
                /// </example>
                public const string ContinentName = "threat.indicator.geo.continent_name";
                
                /// <summary>
                /// Country ISO code.
                /// </summary>
                /// <example>
                /// <c>CA</c>
                /// </example>
                public const string CountryIsoCode = "threat.indicator.geo.country_iso_code";
                
                /// <summary>
                /// Country name.
                /// </summary>
                /// <example>
                /// <c>Canada</c>
                /// </example>
                public const string CountryName = "threat.indicator.geo.country_name";
                
                /// <summary>
                /// Longitude and latitude.
                /// </summary>
                /// <example>
                /// <c>{ "lon": -73.614830, "lat": 45.505918 }</c>
                /// </example>
                public const string Location = "threat.indicator.geo.location";
                
                /// <summary>
                /// User-defined description of a location.
                /// </summary>
                /// <example>
                /// <c>boston-dc</c>
                /// </example>
                public const string Name = "threat.indicator.geo.name";
                
                /// <summary>
                /// Postal code.
                /// </summary>
                /// <example>
                /// <c>94040</c>
                /// </example>
                public const string PostalCode = "threat.indicator.geo.postal_code";
                
                /// <summary>
                /// Region ISO code.
                /// </summary>
                /// <example>
                /// <c>CA-QC</c>
                /// </example>
                public const string RegionIsoCode = "threat.indicator.geo.region_iso_code";
                
                /// <summary>
                /// Region name.
                /// </summary>
                /// <example>
                /// <c>Quebec</c>
                /// </example>
                public const string RegionName = "threat.indicator.geo.region_name";
                
                /// <summary>
                /// Time zone.
                /// </summary>
                /// <example>
                /// <c>America/Argentina/Buenos_Aires</c>
                /// </example>
                public const string Timezone = "threat.indicator.geo.timezone";
                
            }
        }
    }
}

