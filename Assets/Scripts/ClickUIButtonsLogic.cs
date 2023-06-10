using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickUIButtonsLogic : MonoBehaviour
{
    [SerializeField] private BirdAddForce _birdAddForce;
    [SerializeField] private StartGameLogic _startGameLogic;
    [SerializeField] private SoundMode _soundMode;
    [SerializeField] private CanvasesManager _canvasesManager;

    public void ButtonAddForceClick() => _birdAddForce.AddForcePerTouch();

    public void ButtonStartGameClick() => _startGameLogic.StartGame();

    public void ButtonMuteOnClick() => _soundMode.MuteOn();
    public void ButtonMuteOffClick() => _soundMode.MuteOff();
    public void ButtonPlayAgainClick()=>SceneManager.LoadScene(0);
    public void ButtonGameModesClick() => _canvasesManager.OnCanvasChooseGameMode();

    public void ButtonEasyModeClick()
    {
        GameMode.Instance.SetEasyMode();
        PlayerPrefs.SetInt("GameMode", 0);
        SceneManager.LoadScene(0);
    }

    public void ButtonHardModeClick()
    {
        GameMode.Instance.SetHardMode();
        PlayerPrefs.SetInt("GameMode", 1);
        SceneManager.LoadScene(0);
    }
    public void ButtonVeryHardModeClick()
    {
        GameMode.Instance.SetVeryHardMode();
        PlayerPrefs.SetInt("GameMode", 2);
        SceneManager.LoadScene(0);
    }



}
