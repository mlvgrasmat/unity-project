using System;
using UnityEngine;
using UnityEngine.AI;

public class PlayerMovment : MonoBehaviour
{
    public Transform StartPos;
    public float speed = 50f;

    public int stamina = 10;

    public int MaxStamina = 10;

    public int health = 1;

    public float JumpForce = 100f;
    private Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = Vector3.right * speed * Input.GetAxis("Horizontal") * Time.deltaTime;
        transform.position += move;
        if (Input.GetKeyDown(KeyCode.Space) && stamina > 0)
        {
            jump();
        }

    }
    void jump()
    {
        rb.AddForce(Vector3.up * JumpForce);


    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("health"))
        {
            health++;
            Destroy(other.gameObject);
            Debug.Log("health +1");
        }

        if (other.CompareTag("obstacle"))
        {
            health--;
            Destroy(other.gameObject);
            Debug.Log("Healt -1");
        }

        if (other.CompareTag("stamina"))
        {
            stamina++;
            Destroy(other.gameObject);
            Debug.Log("stamina +1");
        }

        if (other.CompareTag("floor"))
        {
            health--;
            if (health <= 0)
            {
                Destroy(transform.gameObject);
            }
            else if (health > 0)
            {
                gameObject.transform.position = StartPos.position;
            }
        }

    }
}


