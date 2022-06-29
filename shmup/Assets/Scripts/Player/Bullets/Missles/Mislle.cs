using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mislle : MonoBehaviour
{
    public Transform target;

    public float moveSpeed;
    public float rotateSpeed = 100f;

    private Rigidbody2D rb;

    public float liveTime = 10.0f;
    public float currentTime = 0.0f;

    public GameObject explosion; //reference to the gameobject the enemy will shoot

    public Transform explosionSpawn; //reference to where the projectile will spawn...

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //target = GameObject.FindGameObjectWithTag("Boss").transform;
        //rb = this.gameObject.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        //rb.velocity = new Vector2(0, 0) * moveSpeed;
        currentTime += 1 * Time.deltaTime;
        if (currentTime > liveTime)
        {
            liveTime += currentTime;
            Die();
            liveTime -= currentTime;
            currentTime = 0.0f;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        target = GameObject.FindGameObjectWithTag("Enemy").transform;

        Vector2 direction = (Vector2)target.position - rb.position;

        direction.Normalize();

        float rotateAmount = Vector3.Cross(direction, transform.up).z;

        rb.angularVelocity = -rotateAmount * rotateSpeed;

        rb.velocity = transform.up * moveSpeed;
    }

    //hit detection 
    void OnCollisionEnter2D(Collision2D col)
    {
        //Debug.Log("Hit " + col.gameObject.tag);
        //when it hits the player
        if (col.gameObject.tag == "Enemy")
        {
            col.gameObject.GetComponent<EnemyHealth>().TakeDamage(40);
            //Instantiate(explosion, explosionSpawn.position, Quaternion.identity);
        }
        Die();
    }
    void Die()
    {
        Instantiate(explosion, explosionSpawn.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
