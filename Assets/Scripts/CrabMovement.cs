using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrabMovement : MonoBehaviour
{
    Rigidbody2D rb;

    public float speed = 5;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        //transform.Translate(Input.GetAxis("Horizontal") * speed * Time.deltaTime, Input.GetAxis("Vetrical") * speed * Time.deltaTime, 0);
        if (transform.position.x > 10.2f)
        {
            Vector3 v = transform.position;
            v.x = 10.2f;
            transform.position = v;
        }
        if (transform.position.x < -10.2f)
        {
            Vector3 v = transform.position;
            v.x = -10.2f;
            transform.position = v;
        }

        if (transform.position.y > 4.5f)
        {
            Vector3 v = transform.position;
            v.y = 4.5f;
            transform.position = v;
        }
        if (transform.position.y < -4.5f)
        {
            Vector3 v = transform.position;
            v.y = -4.5f;
            transform.position = v;
        }

       
    }

    private void FixedUpdate()
    {
        if(Mathf.Abs(Input.GetAxis("Vertical")) > 0.5f)
        {
            rb.rotation = 90;
        }
        if (Mathf.Abs(Input.GetAxis("Horizontal")) > 0.5f) 
        {
            rb.rotation = 0;
        }

        Vector2 v = rb.velocity;
        v.x = Input.GetAxis("Horizontal") * speed;
        v.y = Input.GetAxis("Vertical") * speed;
        rb.velocity = v;

    }
}

