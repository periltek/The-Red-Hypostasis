using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LoadRedData : MonoBehaviour
{
    public RedData redData;

    public TMP_Text titleOfPageText;
    public TMP_Text locationText;
    public TMP_Text dateText;
    public TMP_Text currentTemp;
    public TMP_Text expectedTemp12aText;
    public TMP_Text expectedTemp6aText;
    public TMP_Text expectedTemp12pText;
    public TMP_Text expectedTemp6pText;
    public TMP_Text humidityText;
    public TMP_Text windSpeedText;
    public TMP_Text windDirectionText;
    public TMP_Text importantUpdatesText;
    public TMP_Text marqueeMessageAText;
    public TMP_Text marqueeMessageBText;

    public Image expectedWeatherIcon12a;
    public Image expectedWeatherIcon6a;
    public Image expectedWeatherIcon12p;
    public Image expectedWeatherIcon6p;

    void Start()
    {
        LoadData();
    }

    void LoadData()
    {
        locationText.text = redData.location.ToString();
        dateText.text = redData.date;
        currentTemp.text = redData.currentTemp.ToString() + "°";
        expectedTemp12aText.text = redData.expectedTemp12a.ToString() + "°";
        expectedTemp6aText.text = redData.expectedTemp6a.ToString() + "°";
        expectedTemp12pText.text = redData.expectedTemp12p.ToString() + "°";
        expectedTemp6pText.text = redData.expectedTemp6p.ToString() + "°";
        humidityText.text = redData.humidity.ToString("F1") + "%";
        windSpeedText.text = redData.windSpeed.ToString() + " km/h";
        windDirectionText.text = redData.windDirection.ToString();
        importantUpdatesText.text = redData.importantUpdates;
        marqueeMessageAText.text = redData.marqueeMessageA;
        marqueeMessageBText.text = redData.marqueeMessageB;

        expectedWeatherIcon12a.sprite = redData.expectedWeatherIcon12a;
        expectedWeatherIcon6a.sprite = redData.expectedWeatherIcon6a;
        expectedWeatherIcon12p.sprite = redData.expectedWeatherIcon12p;
        expectedWeatherIcon6p.sprite = redData.expectedWeatherIcon6p;
    }
}
