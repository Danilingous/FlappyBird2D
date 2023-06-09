using UnityEngine;

public class BarrierHoleLogic : MonoBehaviour
{
    private PointCounter _pointCounter;
    [SerializeField] private GameObject _addPointSound;
    void Start()
    {
        _pointCounter = FindObjectOfType<PointCounter>();
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        _pointCounter.AddPoint();
        GameObject newGameObject = Instantiate(_addPointSound, transform.position, Quaternion.identity);
        Destroy(newGameObject, 1.5f);
    }

}
