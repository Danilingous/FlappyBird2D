using System.Collections;
using UnityEngine;

public class CanvasesManager : MonoBehaviour
{
    [SerializeField] private GameObject _canvasAddBirdForceButton;
    [SerializeField] private GameObject _canvasStartButton;
    [SerializeField] private GameObject _canvasEndGame;
    [SerializeField] private GameObject _canvasSoundMode;
    [SerializeField] private GameObject _canvasPointCounter;
    [SerializeField] private GameObject _canvasChooseGameMode;


    public void OffAllCanvases()
    {
        _canvasAddBirdForceButton.SetActive(false);
        _canvasStartButton.SetActive(false);
        _canvasEndGame.SetActive(false);
        _canvasSoundMode.SetActive(false);
        _canvasPointCounter.SetActive(false);
        _canvasChooseGameMode.SetActive(false);
    }

    public void OnCanvasAddBirdForceButton() => _canvasAddBirdForceButton.SetActive(true);
    public void OnCanvasPointCounter() => _canvasPointCounter.SetActive(true);


    public void OnEndGameCanvas()
    {
        _canvasAddBirdForceButton.SetActive(false);
        StartCoroutine(CoroutineOnEndGameCanvas());
    }
   private IEnumerator CoroutineOnEndGameCanvas()
    {
        yield return new WaitForSeconds(1);
        _canvasEndGame.SetActive(true);
        _canvasSoundMode.SetActive(true);

    }

    public void OnCanvasChooseGameMode()
    {
        _canvasEndGame.SetActive(false);
        _canvasPointCounter.SetActive(false);
        _canvasChooseGameMode.SetActive(true);
    }





}
