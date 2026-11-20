using System;
using UnityEngine;

public class MusicButton : MonoBehaviour
{
    [SerializeField] private string _mixerName;

    public event Action<string> MusicChosen;

    public void OnMusicButtonClick()
    {
        MusicChosen?.Invoke(_mixerName);
    }
}
