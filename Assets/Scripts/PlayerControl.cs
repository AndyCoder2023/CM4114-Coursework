using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PlayerControl : MonoBehaviour
{
    public Slider healthBar;
    public TMP_Text healthText;
    public int healthPlayer = 100;
    public int maxHealth = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        maxHealth = healthPlayer;
    }

    // Update is called once per frame
    void Update()
    {
        healthText.text = healthPlayer + " / " + maxHealth;
        healthBar.value = (float)healthPlayer / (float)maxHealth;
    }
    private void onTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            healthPlayer = healthPlayer - 25;
        }
    }
}
