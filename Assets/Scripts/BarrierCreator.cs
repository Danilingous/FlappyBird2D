using System.Collections;
using UnityEngine;

public enum NamesGameMode
{
    Easy = 0,
    Hard = 1,
    VeryHard = 2
}

public class BarrierCreator : MonoBehaviour
{
    [SerializeField] private GameObject _barrierEasyModePrefab;
    [SerializeField] private GameObject _barrierHardModePrefab;

    private NamesGameMode _curentGameMode;


    private void Start()
    {
        _curentGameMode = GameMode.Instance.GetCurentNameGameMode();
        StartCoroutine(CoroutineBarrierCreator(_curentGameMode));
    }

    private IEnumerator CoroutineBarrierCreator(NamesGameMode namesGameMode)
    {
        while (true)
        {
            if ((int)namesGameMode > 0)
            {
                float randomHeight = Random.Range(-3f, 2.8f);
                GameObject barrier = Instantiate(_barrierHardModePrefab, new Vector3(12, randomHeight, 0), Quaternion.identity);
                Destroy(barrier, 30);
            }
            else
            {
                float randomHeight = Random.Range(-1.7f, 2f);
                GameObject barrier = Instantiate(_barrierEasyModePrefab, new Vector3(12, randomHeight, 0), Quaternion.identity);
                Destroy(barrier, 30);
            }
            yield return new WaitForSeconds(2f);

        }
    }
}
