using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicLavaScript : MonoBehaviour
{
    public float speed=0f;
    public float acceleration=0.2f;
    public Rigidbody2D rigidbody2d;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d= GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        speed += acceleration * Time.deltaTime;
        GetComponent<Rigidbody2D>().velocity = new Vector2(0f, speed);
    }
}
