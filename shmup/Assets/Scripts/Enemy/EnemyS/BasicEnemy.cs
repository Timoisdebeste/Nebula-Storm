using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicEnemy: MonoBehaviour
{
    public Rigidbody2D rb;

    public float ySpeed;
    public float xSpeed;

    public bool canShoot;
    public float fireRate;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(xSpeed,ySpeed* -1);
    }

    //hit detection 
    void OnCollisionEnter2D(Collision2D col)
    {   
        if (col.gameObject.tag == "Player")
        {
            col.gameObject.GetComponent<PlayerHealth>().TakeDamage(50);
            //col.gameObject.GetComponent<Numbers>().GainCash(100);
            Die();
        }
        //when it hits the bottom of the screen
        if (col.gameObject.name == "Bottom")
        {
            Die();
        }
    }
    void Die()
    {
        Destroy(gameObject);
    }
}
