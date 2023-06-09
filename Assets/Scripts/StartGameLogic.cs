
using UnityEngine;

public class StartGameLogic : MonoBehaviour
{
    [SerializeField] private BarrierCreator _barrierCreator;
    [SerializeField] private GameObject _birdGameOgject;

    [SerializeField] private GameObject _canvasAddDirdForceButton;
    [SerializeField] private GameObject _canvasStartButton;

    public void StartGame()
    {
        _birdGameOgject.SetActive(true);
        _barrierCreator.enabled= true;

        _canvasStartButton.SetActive(false);
        _canvasAddDirdForceButton.SetActive(true);

    }
}
