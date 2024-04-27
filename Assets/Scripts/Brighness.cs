using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Rendering.PostProcessing;

public class Brighness : MonoBehaviour
{
    public Slider brightnessSlider;
    public PostProcessProfile brightness;
    public PostProcessLayer layer;

    AutoExposure autoExposure;
    void Start()
    {
        brightness.TryGetSettings(out autoExposure);
        AdjustBrightness(brightnessSlider.value);
    }

    public void AdjustBrightness(float value)
    {
        if (value != 0)
        {
            autoExposure.keyValue.value = value;
        }
        else
        {
            autoExposure.keyValue.value = .05f;
        }
    }


}
