using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody rigidbody2D;
    public float speed = 300f;
    private Vector2 velocity;

    // Start is called before the first frame update
    void Start()
    {

        velocity.x = Random.Range(-1f, -1f);
        velocity.y = 1;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
