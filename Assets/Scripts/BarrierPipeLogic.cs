using UnityEngine;

public class BarrierPipeLogic : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
       
        GameObject collisionObject = collision.gameObject;
        if (collisionObject.tag == "Bird")
        {
            Destroy(collisionObject);
        }
    }
}
