
using UnityEngine;

public class StartGameLogic : MonoBehaviour
{
    [SerializeField] private BarrierCreator _barrierCreator;
    [SerializeField] private GameObject _birdGameOgject;

    [SerializeField] private CanvasesManager _canvasesManager;
    

    public void StartGame()
    {
        _birdGameOgject.SetActive(true);
        _barrierCreator.enabled= true;

        _canvasesManager.OffAllCanvases();
        _canvasesManager.OnCanvasAddBirdForceButton();
        _canvasesManager.OnCanvasPointCounter();

    }
}
