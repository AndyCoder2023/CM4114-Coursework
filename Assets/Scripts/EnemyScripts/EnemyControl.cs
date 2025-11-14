using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class EnemyControl : MonoBehaviour
{
    public Slider EnemySlider;
    public TMP_Text EnemyHealthText;

    // Use healthPlayer for the current health value
    public int healthEnemy = 100;
    public int maxHealth = 0;
    public PlayerControl playerControl;

    // Flag to ensure Die logic (like AddKills) runs only once
    private bool isDead = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        maxHealth = healthEnemy;

        // Optional: Set the slider's max value
        EnemySlider.maxValue = maxHealth;
        EnemySlider.minValue = 0;
    }

    // Update is called once per frame
    void Update()
    {
        EnemyHealthText.text = healthEnemy.ToString() + " / " + maxHealth.ToString();
        EnemySlider.value = healthEnemy;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ball" || other.gameObject.tag == "Player")
        {
            // Only process damage if the enemy is alive
            if (!isDead)
            {
                TakeDamage(20);
            }
        }
    }

    public void TakeDamage(int damage)
    {
        // 1. Decrease the healthEnemy variable
        healthEnemy -= damage;

        // 2. Clamp the health so it doesn't go below 0
        healthEnemy = Mathf.Max(0, healthEnemy);

        // 3. Check for death after taking damage
        if (healthEnemy == 0 && !isDead)
        {
            Die();
        }
    }

    public void Die()
    {
        isDead = true;

        // 1. Add kill count to the Player's script
        if (playerControl != null)
        {
            playerControl.killsPlayer++; // Accessing the public int in PlayerControl
        }

        // 2. Destroy the enemy GameObject
        Destroy(gameObject);

        // You might want to add particle effects or sound here before destruction.
    }
}
