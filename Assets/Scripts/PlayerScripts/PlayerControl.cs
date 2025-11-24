using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerControl : MonoBehaviour
{
    public Slider PlayerSlider;
    public TMP_Text healthText;
    public TMP_Text killText;
    public TMP_Text treasureText;

    public int currentHealth;

    // maxHealth will store the starting/maximum health
    public int maxHealth = 100;

    void Start()
    {
        // Set the max health at the start
        currentHealth = maxHealth;

        // Set the slider's max value
        PlayerSlider.maxValue = maxHealth;
        PlayerSlider.minValue = 0;
    }

    void Update()
    {
        // 1. Update the health UI using the local 'currentHealth' variable
        healthText.text = currentHealth.ToString() + " / " + maxHealth.ToString();
        PlayerSlider.value = currentHealth;

        // 2. Update KILLS and TREASURE UI by reading from the PERSISTENT GameStateManager
        if (GameStateManager.instance != null)
        {
            killText.text = GameStateManager.instance.GetKills().ToString();
            treasureText.text = GameStateManager.instance.GetTreasure().ToString();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Player was hit by: " + other.gameObject.name);
        if (other.gameObject.tag == "Enemy")
        {
            Debug.Log("Damage dealt");
            // Only take damage if health is greater than 0
            if (currentHealth > 0)
            {
                TakeDamage(20);
            }
        }
    }

    public void TakeDamage(int damage)
    {
        {
            currentHealth -= damage;
            currentHealth = Mathf.Max(0, currentHealth);

            if (currentHealth == 0)
            {
                Die();
            }
        }
    }

    public void Heal(int amount)
        {
            currentHealth += amount;
            currentHealth = Mathf.Min(currentHealth, maxHealth);
        }

        void Die()
        {
            SceneManager.LoadScene(6);
        }
    }