using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    public float speed = 50f;
    private Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float Horizontal = Input.GetAxis("Horizontal");
        float Verical = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3 (Horizontal, 0f, Verical);

        rb.linearVelocity = new Vector3(
            direction.x * speed,
            rb.linearVelocity.y,
            direction.z * speed
        );
    }
}
