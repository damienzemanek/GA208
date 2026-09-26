using UnityEngine;

public class Muskrat : MonoBehaviour
{
    [SerializeField] Animator _animator;
    [SerializeField] Rigidbody _rigidbody;
    [SerializeField] Collider _collider;
    [SerializeField] float _moveSpeed;
    [SerializeField] float _rotationSpeed;
    [SerializeField] float _jumpForce = 5.0f;

    bool _orbitMode;
    Transform _sphereTransform;

    void Update()
    {
        if (_orbitMode) MoveOrbitMode();
        else MoveNormal();
        TryJump();
    }

    void MoveOrbitMode()
    {
        float horiz = Input.GetAxis("Horizontal");
        float vert = Input.GetAxis("Vertical");

        Vector3 worldUp = transform.TransformDirection(Vector3.up);
        transform.RotateAround(transform.position, worldUp, horiz * _rotationSpeed * Time.deltaTime);

        Vector3 axis = transform.TransformDirection(Vector3.right);
        transform.RotateAround(_sphereTransform.position, axis, vert * _rotationSpeed * Time.deltaTime);
        
        SetAnimationValues(vert);
    }

    void MoveNormal()
    {
        float horiz = Input.GetAxis("Horizontal");
        float vert = Input.GetAxis("Vertical");
        
        Vector3 move = new Vector3(0f, 0f, vert);
        Vector3 rot = new Vector3(0, horiz, 0);
        
        transform.Translate(move * _moveSpeed * Time.deltaTime);
        transform.rotation *= Quaternion.Euler(rot);
        
        SetAnimationValues(vert);
    }

    void SetAnimationValues(float vert)
    {
        Vector3 move = new Vector3(0f, 0f, vert);
        bool moving = move.magnitude > 0;
        var localVel = transform.InverseTransformDirection(_rigidbody.linearVelocity);
        Debug.Log(localVel);
        bool movingUpOrDown = Mathf.Abs(localVel.y) > 0.1f;
        _animator.SetBool("running", moving);
        _animator.SetBool("flying", movingUpOrDown);
    }
    

    void TryJump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rigidbody.isKinematic = false;
            _rigidbody.AddForce(Vector3.up * _jumpForce, ForceMode.Impulse);

            if (_sphereTransform != null)
            {
                Destroy(_sphereTransform.gameObject);
                _sphereTransform = null;
            }

            _orbitMode = false;
        }
    }

    // ------------------------------------------------------------------------
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Ball"))
        {
            _orbitMode = true;
            _rigidbody.isKinematic = true;

            _sphereTransform = collision.transform;

            ContactPoint contact = collision.GetContact(0);

            // tangent OF the normal is 90 degrees
            // taking the cross product of 2 angles get the vector perpedicular to both --> Which is the forward direction if we use Vector3.right
            Vector3 tangent = Vector3.Cross(Vector3.right, contact.normal);
            
            // Apply pos and rot
            Quaternion forwardRotation = Quaternion.LookRotation(tangent, contact.normal);
            
            transform.SetPositionAndRotation(contact.point, forwardRotation);
        }
    }
}
