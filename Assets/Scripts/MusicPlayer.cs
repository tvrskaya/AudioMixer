using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    [SerializeField] private MusicButton[] _musicButtons;
    [SerializeField] private MusicSlider _musicSlider;
    [SerializeField] private MuteButton _muteButton;
    [SerializeField] private MasterSlider _masterSlider; 

    private void OnEnable()
    {
        foreach (var musicButton in _musicButtons)
            musicButton.MusicChosen += ProcessMusicButtonChosen;

        _muteButton.MutePressed += ProcessMutePressed; 
    }

    private void OnDisable()
    {
        foreach (var musicButton in _musicButtons)
            musicButton.MusicChosen -= ProcessMusicButtonChosen;

        _muteButton.MutePressed -= ProcessMutePressed;
    }

    private void ProcessMusicButtonChosen(string mixerName)
    {
        _musicSlider.SetCurrentMusic(mixerName);
    }

    private void ProcessMutePressed()
    {
        _masterSlider.TurnInteractable();
    }
}
