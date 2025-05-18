using UnityEngine;

public class BlackHoleScript : MonoBehaviour
{
    [SerializeField] float force = 10;
    [SerializeField, Min(0)] float destroyDistsnce = 0.1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        Vector2 direction = transform.position - collision.transform.position;
        float distance = direction.magnitude;
        direction.Normalize();
        collision.attachedRigidbody.AddForce(force / distance / distance * direction);
        if (distance > destroyDistsnce) return;
        Destroy(collision.gameObject);
    }
}
