using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class EnemyControl : MonoBehaviour
{
    public Slider EnemySlider;
    public TMP_Text EnemyHealthText;
    public TMP_Text KillText;

    public int healthEnemy = 100;
    public int maxHealth = 0;
    public int playerKills = 0;

    // Flag to ensure Die logic (like AddKills) runs only once
    private bool isDead = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (maxHealth == 0)
            maxHealth = healthEnemy;

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
        // || other.gameObject.tag == "Player" "maybe add"
        if (other.gameObject.tag == "ball")
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

        // 2. stop the health count so it doesn't go below 0
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

        // Update the persistent GameStateManager
        if (GameStateManager.instance != null)
        {
            // Add a single kill to the persistent count
            GameStateManager.instance.AddToKills(1);
            Debug.Log("Enemy destroyed. New persistent kill count: " + GameStateManager.instance.GetKills());
        }

        // 2. Destroy the enemy GameObject
        Destroy(gameObject, 0.1f); // Added a small delay for visual effect/particles if needed
    }
}

// AI Gemini helped with debugging the code and implementing placeholders for further game structure.
