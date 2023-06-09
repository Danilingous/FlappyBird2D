using UnityEngine;

public class BarrierPipeLogic : MonoBehaviour
{
     private GameObject _barrierCreator;
    private void Start()
    {
        _barrierCreator = FindObjectOfType<BarrierCreator>().gameObject;
    }
    private void OnCollisionEnter2D(Collision2D collision)
        
    {
       
        GameObject collisionObject = collision.gameObject;
        if (collisionObject.tag == "Bird")
        {
            BarrierForwardMove[] barriers = FindObjectsOfType<BarrierForwardMove>();
            for (int i = 0; i < barriers.Length; i++) barriers[i].Speed = 0;
            if (_barrierCreator) Destroy(_barrierCreator);
            Destroy(collisionObject);
        }
    }
}
