
using UnityEngine;

public class ClickUIButtonsLogic : MonoBehaviour
{
    [SerializeField] private BirdAddForce _birdAddForce;
    [SerializeField] private StartGameLogic _startGameLogic;
    [SerializeField] private SoundMode _soundMode;

    public void ButtonAddForceClick() => _birdAddForce.AddForcePerTouch();

    public void ButtonStartGameClick() => _startGameLogic.StartGame();

    public void ButtonMuteOnClick() => _soundMode.MuteOn();
    public void ButtonMuteOffClick() => _soundMode.MuteOff();

}
