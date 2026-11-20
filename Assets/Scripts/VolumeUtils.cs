using UnityEngine;

public static class VolumeUtils
{
    private static readonly float SliderToDecibelsScale = 20f;
    private static readonly float DecibelLogBase = 10f;

    public static float ConvertSliderToDecibels(float value)
    {
        return Mathf.Log10(value) * SliderToDecibelsScale;
    }

    public static float ConvertDecibelsToSlider(float decibels)
    {
        return Mathf.Pow(DecibelLogBase, decibels / SliderToDecibelsScale); 
    }

}
