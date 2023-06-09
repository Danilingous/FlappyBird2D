using UnityEngine;

public class BarrierForwardMove : MonoBehaviour
{
     public float Speed;
    private void Start()
    {
        Speed = GameMode.Instance.GetCurentSpeedBarrierForwardMove();
    }
    void Update()
    {
        transform.position -= new Vector3(Speed*Time.deltaTime, 0, 0);

    }
}
