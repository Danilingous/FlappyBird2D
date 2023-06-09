using UnityEngine;

public class BarrierHoleLogic : MonoBehaviour
{
    private PointCounter _pointCounter;
    void Start()
    {
        _pointCounter = FindObjectOfType<PointCounter>();
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        _pointCounter.AddPoint();
    }

}
