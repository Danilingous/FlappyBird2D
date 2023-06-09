using UnityEngine;

public class BirdAddForce : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigitbody;
    [SerializeField] private float _forceValue = 5f;
    public void AddForcePerTouch()
    {
        _rigitbody.velocity = Vector2.up * _forceValue;
    }
}
