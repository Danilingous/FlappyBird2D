using UnityEngine;

public class SoundMode : MonoBehaviour
{
    [SerializeField] private GameObject _buttonMuteOn;
    [SerializeField] private GameObject _buttonMuteOff;
    private void Start()
    {
        if (GameMode.Instance.GetMuteStatus())
        {
            _buttonMuteOff.SetActive(true);
            AudioListener.volume = 0;
        }
        else
        {
            _buttonMuteOn.SetActive(true);
            AudioListener.volume = 1;
        }
    }

    public void MuteOn()
    {
        _buttonMuteOn.SetActive(false);
        _buttonMuteOff.SetActive(true);
        AudioListener.volume = 0;
        GameMode.Instance.OnMute();
        PlayerPrefs.SetInt("isMute", 1);
    }

    public void MuteOff()
    {
        _buttonMuteOn.SetActive(true);
        _buttonMuteOff.SetActive(false);
        AudioListener.volume = 1;
        GameMode.Instance.OffMute();
        PlayerPrefs.SetInt("isMute", 0);
    }


}
