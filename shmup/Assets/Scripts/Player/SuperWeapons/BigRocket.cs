using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigRocket : MonoBehaviour
{
    public Rigidbody2D rb;// refrence to a rigidbody2d

    public float moveSpeed = 10.0f;

    public GameObject projectile; //reference to the gameobject the enemy will shoot

    public Transform projectileSpawn; //reference to where the projectile will spawn...

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
            col.gameObject.GetComponent<EnemyHealth>().TakeDamage(200);
            Instantiate(projectile, projectileSpawn.position, Quaternion.identity);
        }
        Die();
    }
    void Die()
    {
        Destroy(gameObject);
    }
}
