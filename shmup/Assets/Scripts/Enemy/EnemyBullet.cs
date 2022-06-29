using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public Rigidbody2D rb;

    public float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(0, -1) * moveSpeed;
    }

    //hit detection 
    void OnCollisionEnter2D(Collision2D col)
    {
        //when it hits the player
        if (col.gameObject.tag == "Player")
        {
            col.gameObject.GetComponent<SpaceShip>().TakeDamage(10);
        }
        //when it hits the top of the screen
        if (col.gameObject.name == "Top") {}
        //when it hits the bottom of the screen
        if (col.gameObject.name == "Bottom") {}
        Die();
    }
    void Die()
    {
        Destroy(gameObject);
    }
}