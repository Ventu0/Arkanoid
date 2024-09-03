using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controleDeBola : MonoBehaviour
{
    public float for�aDeLan�amento = 1f;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            LaunchBall();
        }
        else
        {
            Debug.LogError("deuN�o");
        }
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(new Vector2(Random.Range(-1f, 1f), 1) * for�aDeLan�amento);
    }
    void LaunchBall()
    {
  
        Vector2 direction = new Vector2(Random.Range(-1f, 1f), 1).normalized;

        rb.velocity = Vector2.zero; 
        rb.angularVelocity = 0;

        rb.AddForce(direction * for�aDeLan�amento);
    }
}
