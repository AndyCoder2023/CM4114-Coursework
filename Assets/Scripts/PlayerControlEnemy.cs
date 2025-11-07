using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PlayerControlEnemy : MonoBehaviour
{
    public Slider healthBar;
    public TMP_Text healthText;
    public int health = 100;
    public int maxHealth = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        maxHealth = health;
    }

    // Update is called once per frame
    void Update()
    {
        healthText.text = health + " / " + maxHealth;
        healthBar.value = (float)health / (float)maxHealth;
    }
    private void onTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "")
        {
            health = health - 25;
        }
    }
}
