using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int maxHealth = 1000;
    public int currentHealthEnemy;

    public HealthBar healthBar;

    //public GameObject deathEffect;
    public bool isBoss;
    public GameObject completeLevelUI;

    // Start is called before the first frame update
    void Start()
    {
        currentHealthEnemy = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        //when it hits the player
        if (col.gameObject.tag == "Player")
        {
            col.gameObject.GetComponent<PlayerHealth>().TakeDamage(10);
            TakeDamage(100);
        }
    }

    public void TakeDamage(int damage)
    {
        currentHealthEnemy -= damage;

        healthBar.SetHealth(health: currentHealthEnemy);

        if (currentHealthEnemy < 1)
        {
            if (isBoss)
            completeLevelUI.SetActive(true);
            Die();

            //SceneManager.LoadScene(nextSceneToLoad);
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
