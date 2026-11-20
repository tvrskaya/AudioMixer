using System;
using UnityEngine;
using UnityEngine.Audio;

public class MuteButton : MonoBehaviour
{
    private static readonly string MasterVolumeName = "MasterVolume";
    private static readonly float OffDecibelsValue = -80f;

    public event Action MutePressed;

    [SerializeField] private AudioMixer _mixer;

    private float _savedDecibels;
    private bool _isMuted = false;

    public void OnButtonPressed()
    {
        _isMuted = !_isMuted;

        if (_isMuted == true)
        {
            _mixer.GetFloat(MasterVolumeName, out _savedDecibels);
            _mixer.SetFloat(MasterVolumeName, OffDecibelsValue);
        }
        else
        {
            _mixer.SetFloat(MasterVolumeName, _savedDecibels);
        }

        MutePressed?.Invoke();
    }
}
