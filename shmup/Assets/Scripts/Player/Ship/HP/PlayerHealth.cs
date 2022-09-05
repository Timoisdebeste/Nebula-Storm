using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    private int nextSceneToLoad;

    public int maxHealth = 100;
    public int currentHealth;

    public HealthBar healthBar;
    public float moveSpeed = 10.0f;

    private void Start()
    {
        nextSceneToLoad = (1);

        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
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
