using UnityEngine;

public class BarrierPipeLogic : MonoBehaviour
{
    // [SerializeField] private GameObject _crashSoundPrefab;
    [SerializeField] private GameObject _loseSoundPrefab;
    private GameObject _barrierCreator;
    private CanvasesManager _canvasesManager;
    private void Start()
    {
        _barrierCreator = FindObjectOfType<BarrierCreator>().gameObject;
        _canvasesManager = FindObjectOfType<CanvasesManager>();
    }
    private void OnCollisionEnter2D(Collision2D collision)

    {

        GameObject collisionObject = collision.gameObject;
        if (collisionObject.tag == "Bird")
        {
            //  Instantiate(_crashSoundPrefab, transform.position, Quaternion.identity);
            Instantiate(_loseSoundPrefab, transform.position, Quaternion.identity);
            BarrierForwardMove[] barriers = FindObjectsOfType<BarrierForwardMove>();
            for (int i = 0; i < barriers.Length; i++) barriers[i].Speed = 0;
            _canvasesManager.OnEndGameCanvas();
            if (_barrierCreator) Destroy(_barrierCreator);
            Destroy(collisionObject);
        }
    }
}
