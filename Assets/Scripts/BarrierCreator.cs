using System.Collections;
using UnityEngine;

public class BarrierCreator : MonoBehaviour
{
    [SerializeField] private GameObject _barrierPrefab;


    private void Start()
    {
        StartCoroutine(CoroutineBarrierCreator());
    }

    private IEnumerator CoroutineBarrierCreator()
    {
        while (true)
        {
            float randomHeight = Random.Range(-1.7f, 2f);
            Instantiate(_barrierPrefab,new Vector3(12,randomHeight,0), Quaternion.identity);    
        }
    }
}
