using UnityEngine;

public class BirdAddForce : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigitbody;
    [SerializeField] private float _forceValue = 5f;
    [SerializeField] private GameObject _wingsSoundPrefab;
 
    public void AddForcePerTouch()
    {
        if (_rigitbody)
        {
            _rigitbody.velocity = Vector2.up * _forceValue;
            GameObject newGameObject = Instantiate(_wingsSoundPrefab, transform.position,Quaternion.identity);
            Destroy(newGameObject, 1);
        }
    }
    //private IEnumerator CoroutineCreateWingsSound()
    //{
    //   GameObject newGameObject = Instantiate(_wingsSoundPrefab, transform.position, transform.rotation);
    //    yield return new WaitForSeconds(1f);
    //    Destroy(newGameObject);

    //}

}
