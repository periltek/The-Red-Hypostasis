using UnityEditor;
using UnityEngine;

public class WriteRedData : MonoBehaviour
{
    [MenuItem("Assets/Create/RedData")]
    public static void CreateRedData()
    {
        RedData asset = ScriptableObject.CreateInstance<RedData>();

        // Set default values for the asset here if necessary
        asset.location = Location.Slade_Ky;
        asset.date = "01/01/2024";
        asset.currentTemp = 95;
        asset.expectedTemp12a = 0;
        asset.expectedTemp6a = 0;
        asset.expectedTemp12p = 0;
        asset.expectedTemp6p = 0;
        asset.expectedWeatherIcon12a = null;
        asset.expectedWeatherIcon6a = null;
        asset.expectedWeatherIcon12p = null;
        asset.expectedWeatherIcon6p = null;
        asset.humidity = 0.0f;
        asset.windSpeed = 0;
        asset.windDirection = WindDirection.N;
        asset.skies = Skies.clear;
        asset.precip = PrecipitationTypes.NoWind;
        asset.visibilityInMiles = 0.0f;
        asset.visibiityStatement = SpecialWeather.None;
        asset.extremeWeather = ExtremeWeather.None;
        asset.importantUpdates = "No updates.";
        asset.marqueeMessageA = "No message.";
        asset.marqueeMessageB = "No message.";
        asset.SpecialWeatherStatement = new string[0];

        string path = AssetDatabase.GenerateUniqueAssetPath("Assets/NewRedData.asset");

        AssetDatabase.CreateAsset(asset, path);
        AssetDatabase.SaveAssets();

        EditorUtility.FocusProjectWindow();
        Selection.activeObject = asset;
    }
}
