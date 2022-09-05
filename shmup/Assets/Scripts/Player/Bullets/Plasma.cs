using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plasma : MonoBehaviour
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
        rb.velocity = new Vector2(0, 1) * moveSpeed;
    }

    private void FixedUpdate()
    {
        //Vector2 pos = transform.position;

        //float sin = Mathf.Sin(pos.y);
        //pos.x = sin;

        //transform.position = pos;
    }

    //hit detection 
    void OnCollisionEnter2D(Collision2D col)
    {
        //Debug.Log("Hit " + col.gameObject.tag);
        //when it hits the player
        if (col.gameObject.tag == "Enemy")
        {
            col.gameObject.GetComponent<EnemyHealth>().TakeDamage(60);
        }
        Die();
    }
    void Die()
    {
        Destroy(gameObject);
    }
}
