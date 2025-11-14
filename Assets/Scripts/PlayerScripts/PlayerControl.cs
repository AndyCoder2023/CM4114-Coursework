using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerControl : MonoBehaviour
{
    // These should be assigned in the Inspector
    public Slider PlayerSlider;
    public TMP_Text healthText;
    public TMP_Text killText;
    public TMP_Text treasureText;

    // Use healthPlayer for the current health value
    public int healthPlayer = 100;
    public int killsPlayer = 0;
    public int treasurePlayer = 0;

    // maxHealth will store the starting/maximum health
    public int maxHealth = 0;
    public int maxKills = 0;
    public int maxTreasure = 0;

    void Start()
    {
        // Set the max health at the start
        maxHealth = healthPlayer;

        // Optional: Set the slider's max value
        PlayerSlider.maxValue = maxHealth;
        PlayerSlider.minValue = 0;
    }

    void Update()
    {
        // Update the text and slider value every frame
        healthText.text = healthPlayer.ToString() + " / " + maxHealth.ToString();
        // The slider's value is set based on the healthPlayer variable
        PlayerSlider.value = healthPlayer;

        // Update the text value for kills
        killText.text = killsPlayer.ToString();

        // Update the text value for treasure
        treasureText.text = treasurePlayer.ToString();

    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Player was hit by: " + other.gameObject.name);
        if (other.gameObject.tag == "Enemy")
        {
            Debug.Log("Damage dealt");
            // Only take damage if health is greater than 0
            if (healthPlayer > 0)
            {
                TakeDamage(20);
            }
        }
    }

    public void TreasureCounter()
    {
        //if (gameObject.Player)
        //    treasurePlayer++;
    }

    public void TakeDamage(int damage)
    {
        // 1. Decrease the healthPlayer variable
        healthPlayer -= damage;

        // 2. Clamp the health so it doesn't go below 0
        healthPlayer = Mathf.Max(0, healthPlayer);

        // 3. The Update method will automatically update the Slider and Text
        //    based on the new healthPlayer value.
        if (healthPlayer == 0)
        {
            Die();
        }
    }

    public void Heal(int amount)
    {
        // Increase health by the specified amount
        healthPlayer += amount;

        // Clamp the health so it doesn't go over maxHealth
        // This is important for healing
        healthPlayer = Mathf.Min(healthPlayer, maxHealth);

        // The Update method will automatically refresh the UI (Slider and Text)
        // based on the new healthPlayer value.
    }

    public void Treasure(int amount)
    {
        // Increase health by the specified amount
        treasurePlayer += amount;
    }

    public void Die()
    {
            SceneManager.LoadScene(6);
    }
}

// AI Gemini helped with fixing this script