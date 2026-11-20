using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class VolumeSlider : MonoBehaviour
{
    [SerializeField] protected AudioMixer _mixer;
    [SerializeField] protected string _mixerName;

    protected Slider _slider;

    protected virtual void Awake()
    {
        _slider = GetComponent<Slider>();

        _mixer.GetFloat(_mixerName, out var decibels);

        float sliderValue = VolumeUtils.ConvertDecibelsToSlider(decibels);
        _slider.SetValueWithoutNotify(sliderValue);
    }

    public virtual void ChangeVolume(float value)
    {
        _mixer.SetFloat(_mixerName,
                VolumeUtils.ConvertSliderToDecibels(value));
    }
}
