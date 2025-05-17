using UnityEngine;

public class Launcher : MonoBehaviour
{
    [SerializeField] new Rigidbody2D rigidbody;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (rigidbody == null) rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Launch(Vector2 force)
    {
        rigidbody.AddForce(force, ForceMode2D.Impulse);
    }
}
