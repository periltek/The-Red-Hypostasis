using UnityEngine;

[CreateAssetMenu(fileName = "Red Weather Data", menuName = "RedData")]
public class RedData : ScriptableObject
{
    public Location location;
    public string date;
    [Range(0, 150)] public int currentTemp;
    [Range(0, 150)] public int expectedTemp12a;
    [Range(0, 150)] public int expectedTemp6a;
    [Range(0, 150)] public int expectedTemp12p;
    [Range(0, 150)] public int expectedTemp6p;
    public Sprite expectedWeatherIcon12a;
    public Sprite expectedWeatherIcon6a;
    public Sprite expectedWeatherIcon12p;
    public Sprite expectedWeatherIcon6p;
    [Range(0, 100)] public float humidity;
    public int windSpeed;
    public WindDirection windDirection;
    public Skies skies;
    public PrecipitationTypes precip;
    [Range(0, 10)] public float visibilityInMiles;
    public SpecialWeather visibiityStatement;
    public ExtremeWeather extremeWeather;
    public string importantUpdates;
    public string marqueeMessageA;
    public string marqueeMessageB;
    public string[] SpecialWeatherStatement;
}

public enum WindDirection
{
    none, N, NE, E, SE, S, SW, W, NW
}

public enum Skies
{
    clear, partlyCloudy, mostlyCloudy, overcast
}

public enum PrecipitationTypes
{
    NoWind, rain, sleet, hail, snow, freezingRain, debris
}

public enum SpecialWeather
{
    None, HighSpeedWinds, TorrentialRainfall, LowAirQuality, freezingTemperatures, highTemperatures
}

public enum ExtremeWeather
{
    None, Heatwave, ColdWave, Blizzard, ThunderStorm, HailStorm, IceStorm, Tornado, ForestFire, Flooding, Rockslide
}

public enum SpecialWeatherC
{
    heatStroke, dehydration
}

public enum Location
{
    Slade_Ky, Rogers, GlenCairn, Campton, Nada, Gladie, IndianCreek, Bowen, Torrent
}
