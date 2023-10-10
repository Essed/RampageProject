using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float speed;
    
    private Vector3 direction;

    public Vector3 Direction
    {
        get { return direction; }
        set { direction = value; }
    }

    private void OnTriggerEnter(Collider other)
    {        
        if (other.GetComponent<BoxCollider>())
        {           
            Destroy(gameObject);
        }       
    }

    private void FixedUpdate()
    {
        MoveBullet(direction);
    }

    private void MoveBullet(Vector3 _direction)
    {
        rb.AddForce(_direction * speed * Time.fixedDeltaTime);
    }

}
