using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoBemBala : MonoBehaviour
{
    public float speed = 10f;
    private float moveInput;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        moveInput = Input.GetAxis("Horizontal");
        Vector3 move = new Vector3(moveInput, 0, 0);
        transform.Translate(move * speed * Time.deltaTime);     

    }
}
