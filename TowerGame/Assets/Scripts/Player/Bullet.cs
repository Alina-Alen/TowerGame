using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float speed = -20f;
    public Rigidbody2D rb;
    private EnemyHealth enemy;

    public string bulletType = "pink";
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;


    }

    void Update()
    {
    }

    void OnTriggerEnter2D (Collider2D collision)
    {

        
        enemy = collision.GetComponent<EnemyHealth>();


        if(enemy != null)
        {
            //pink beats yellow
            //yellow beats green
            //green beats pink
            if ((enemy.getColor() == "yellow" && bulletType == "pink") || (enemy.getColor() == "green" && bulletType == "yellow") 
                || enemy.getColor() == "pink" && bulletType == "green")
            {
                enemy.TakeDamage();
            } 
            
        }
        Destroy(gameObject);
    }
   
}
