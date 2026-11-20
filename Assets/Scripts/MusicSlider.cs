using UnityEngine;
using UnityEngine.UI;

public class MusicSlider : VolumeSlider
{
    public void SetCurrentMusic(string mixerName)
    {
        if (!_mixer.GetFloat(mixerName, out var decibels))
        {
            Debug.Log("WARN: No such mixer");
            return;
        }

        _mixerName = mixerName;

        float sliderValue = VolumeUtils.ConvertDecibelsToSlider(decibels);
        _slider.SetValueWithoutNotify(sliderValue);
    }
}
