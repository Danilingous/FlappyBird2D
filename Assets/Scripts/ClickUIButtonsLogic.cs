
using UnityEngine;

public class ClickUIButtonsLogic : MonoBehaviour
{
    [SerializeField] private BirdAddForce _birdAddForce;
    [SerializeField] private StartGameLogic _startGameLogic;

    public void ButtonAddForceClick() => _birdAddForce.AddForcePerTouch();

    public void ButtonStartGameClick() => _startGameLogic.StartGame();

}
