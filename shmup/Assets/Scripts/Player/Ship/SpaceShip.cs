using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpaceShip : MonoBehaviour 
{
    private int nextSceneToLoad;

    public int maxHealth = 100;
    public int currentHealth;

    public HealthBar healthBar;
    public float moveSpeed = 10.0f;

    public Rigidbody2D rb;

    public bool movoable = true;

    //public GameObject ondeathUI;
    //public GameObject ondeath;


    // Start is called before the first frame update
    void Start()
    {
        nextSceneToLoad = (1);

        rb = GetComponent<Rigidbody2D>();

        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
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

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthBar.SetHealth(health: currentHealth);

        if (currentHealth < 1)
        {
            //ondeathUI.SetActive(true);
            //ondeath.SetActive(false);
            Die();

            SceneManager.LoadScene(nextSceneToLoad);
        }
    }
    void Die()
    {
        Destroy(gameObject);
    }
}
