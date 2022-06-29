using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannonshell : MonoBehaviour
{
    public Rigidbody2D rb;// refrence to a rigidbody2d

    public float moveSpeed = 10.0f;

    public GameObject explosion; //reference to the gameobject the enemy will shoot

    public Transform explosionSpawn; //reference to where the projectile will spawn...

    // Start is called before the first frame update
    void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(0, 1) * moveSpeed;
    }

    //hit detection 
    void OnCollisionEnter2D(Collision2D col)
    {
        //Debug.Log("Hit " + col.gameObject.tag);
        //when it hits the player
        if (col.gameObject.tag == "Enemy")
        {
            col.gameObject.GetComponent<EnemyHealth>().TakeDamage(75);
        }
        Die();
    }
    void Die()
    {
        Instantiate(explosion, explosionSpawn.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
