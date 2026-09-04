using UnityEngine;

public class VelocityGizmo : MonoBehaviour 
{
    [SerializeField] private Rigidbody2D _rigidbody;

    private void OnDrawGizmos ()
    {
        if(_rigidbody == null) return;
        
        Gizmos.color = Color.red;
        Vector3 velocity = new Vector3(_rigidbody.linearVelocity.x, _rigidbody.linearVelocity.y, 0);
        Gizmos.DrawRay(transform.position, velocity);
    }
}