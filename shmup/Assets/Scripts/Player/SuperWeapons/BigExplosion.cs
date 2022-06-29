using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigExplosion : MonoBehaviour
{
    public Rigidbody2D rb;

    public float moveSpeed;

    public float nextFire = 1.0f;
    public float currentTime = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //rb.velocity = new Vector2(0, 0) * moveSpeed;
        currentTime += 1;
        if (currentTime > nextFire)
        {
            nextFire += currentTime;
            Die();
            nextFire -= currentTime;
            currentTime = 0.0f;
        }
    }

    private void OnTriggerEnter(Collider other)
    {

    }
    //hit detection 
    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("Hit " + col.gameObject.tag);
        //when it hits the player
        if (col.gameObject.tag == "Enemy")
        {
            col.gameObject.GetComponent<EnemyHealth>().TakeDamage(300);
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}