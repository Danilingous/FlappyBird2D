using UnityEngine;

public class BarrierForwardMove : MonoBehaviour
{

    [SerializeField] private float _speed=2f;
    void Update()
    {
        transform.position -= new Vector3(_speed*Time.deltaTime, 0, 0);

    }
}
