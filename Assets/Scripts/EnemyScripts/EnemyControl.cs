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

    //public GameObject Enemy;

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
        EnemySlider.value = (float)healthEnemy / (float)maxHealth;
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Player was hit by: " + other.gameObject.name);
        if (other.gameObject.tag == "Enemy")
        {
            Debug.Log("Damage dealt");
            // Only take damage if health is greater than 0
            if (healthEnemy > 0)
            {
                TakeDamage(20);
            }
        }
    }

    public void TakeDamage(int damage)
    {
        // 1. Decrease the healthPlayer variable
        healthEnemy -= damage;

        // 2. Clamp the health so it doesn't go below 0
        healthEnemy = Mathf.Max(0, healthEnemy);

        // 3. The Update method will automatically update the Slider and Text
        //    based on the new healthPlayer value.
    }
}
