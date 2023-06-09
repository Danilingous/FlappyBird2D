using UnityEngine;

public class BarrierForwardMove : MonoBehaviour
{
     private float _speed;
    private void Start()
    {
        _speed = GameMode.Instance.GetCurentSpeedBarrierForwardMove();
    }
    void Update()
    {
        transform.position -= new Vector3(_speed*Time.deltaTime, 0, 0);

    }
}
