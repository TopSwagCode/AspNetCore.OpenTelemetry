using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

public class ConsolidatedWeather {
        [JsonPropertyName("id")]
        public object Id { get; set; } 

        [JsonPropertyName("weather_state_name")]
        public string WeatherStateName { get; set; } 

        [JsonPropertyName("weather_state_abbr")]
        public string WeatherStateAbbr { get; set; } 

        [JsonPropertyName("wind_direction_compass")]
        public string WindDirectionCompass { get; set; } 

        [JsonPropertyName("created")]
        public DateTime Created { get; set; } 

        [JsonPropertyName("applicable_date")]
        public string ApplicableDate { get; set; } 

        [JsonPropertyName("min_temp")]
        public double MinTemp { get; set; } 

        [JsonPropertyName("max_temp")]
        public double MaxTemp { get; set; } 

        [JsonPropertyName("the_temp")]
        public double TheTemp { get; set; } 

        [JsonPropertyName("wind_speed")]
        public double WindSpeed { get; set; } 

        [JsonPropertyName("wind_direction")]
        public double WindDirection { get; set; } 

        [JsonPropertyName("air_pressure")]
        public double AirPressure { get; set; } 

        [JsonPropertyName("humidity")]
        public int Humidity { get; set; } 

        [JsonPropertyName("visibility")]
        public double Visibility { get; set; } 

        [JsonPropertyName("predictability")]
        public int Predictability { get; set; } 
    }

    public class Parent    {
        [JsonPropertyName("title")]
        public string Title { get; set; } 

        [JsonPropertyName("location_type")]
        public string LocationType { get; set; } 

        [JsonPropertyName("woeid")]
        public int Woeid { get; set; } 

        [JsonPropertyName("latt_long")]
        public string LattLong { get; set; } 
    }

    public class Source    {
        [JsonPropertyName("title")]
        public string Title { get; set; } 

        [JsonPropertyName("slug")]
        public string Slug { get; set; } 

        [JsonPropertyName("url")]
        public string Url { get; set; } 

        [JsonPropertyName("crawl_rate")]
        public int CrawlRate { get; set; } 
    }

    public class WeatherForecast {
        [JsonPropertyName("consolidated_weather")]
        public List<ConsolidatedWeather> ConsolidatedWeather { get; set; } 

        [JsonPropertyName("time")]
        public DateTime Time { get; set; } 

        [JsonPropertyName("sun_rise")]
        public DateTime SunRise { get; set; } 

        [JsonPropertyName("sun_set")]
        public DateTime SunSet { get; set; } 

        [JsonPropertyName("timezone_name")]
        public string TimezoneName { get; set; } 

        [JsonPropertyName("parent")]
        public Parent Parent { get; set; } 

        [JsonPropertyName("sources")]
        public List<Source> Sources { get; set; } 

        [JsonPropertyName("title")]
        public string Title { get; set; } 

        [JsonPropertyName("location_type")]
        public string LocationType { get; set; } 

        [JsonPropertyName("woeid")]
        public int Woeid { get; set; } 

        [JsonPropertyName("latt_long")]
        public string LattLong { get; set; } 

        [JsonPropertyName("timezone")]
        public string Timezone { get; set; } 
    }

