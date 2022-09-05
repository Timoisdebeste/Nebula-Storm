using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpaceShip : MonoBehaviour 
{
    public Rigidbody2D rb;

    public float moveSpeed = 10f;

    public bool movoable = true;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer ();
    }

    public void MovePlayer()
    {
        if (movoable)
        {
            rb.velocity = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")) * moveSpeed;
        } else
        {
            rb.velocity = new Vector2(0, 0) * 0;
        }
    }
}
