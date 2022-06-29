using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperLaser : MonoBehaviour
{
    public Rigidbody2D rb;

    float nextFire = 5.0f;
    float currentTime = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        GameObject[] players = GameObject.FindGameObjectsWithTag("Player");
        players[0].GetComponent<SpaceShip>().movoable = false;
        rb = this.gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //rb.velocity = new Vector2(0, 0) * moveSpeed;
        currentTime += Time.deltaTime;
        if (currentTime > nextFire)
        {
            nextFire += currentTime;
            Die();
            nextFire -= currentTime;
            currentTime = 0.0f;
        }
    }

    //hit detection 
    void OnCollisionEnter2D(Collision2D col)
    {
        //Debug.Log("Hit " + col.gameObject.tag);
        //when it hits the player
        if (col.gameObject.tag == "Enemy")
        {
            col.gameObject.GetComponent<EnemyHealth>().TakeDamage(300);
        }
    }

    void Die()
    {
        GameObject[] players = GameObject.FindGameObjectsWithTag("Player");
        players[0].GetComponent<SpaceShip>().movoable = true;
        Destroy(gameObject);
    }
}