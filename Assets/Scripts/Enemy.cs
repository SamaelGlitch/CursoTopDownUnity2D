using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private int maxHealth = 100;
    private int currentHealth;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    public void Daño(int daño)
    {
        currentHealth -= daño;
        if (currentHealth <= 0)
        {
            GameOver();
        }
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            Debug.Log("Recibi daño");
            Daño(25);
        }
    }

    private void GameOver()
    {
        Destroy(gameObject);
    }
}
