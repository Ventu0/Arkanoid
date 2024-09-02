using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class maxspeed : MonoBehaviour
{
    public float speed = 15f;
    public float maxSpeed = 30f;
    private Vector2 direction;

    // Start is called before the first frame update
    void Start()
    {
        direction = new Vector2(1f, 1f).normalized;
        GetComponent<Rigidbody2D>().velocity = direction * speed;
    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        if (rb.velocity.magnitude > maxSpeed)
        {
            rb.velocity = rb.velocity.normalized * maxSpeed;
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("bloco"))
        {
            Destroy(collision.gameObject);
        }
    }
}

