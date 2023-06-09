
using UnityEngine;

public class ClickUIButtonsLogic : MonoBehaviour
{
    [SerializeField] private BirdAddForce _birdAddForce;

    public void ButtonAddForceClick() => _birdAddForce.AddForcePerTouch();

}
