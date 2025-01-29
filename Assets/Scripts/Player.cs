using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private int maxHealth = 100;
    [SerializeField] private int currentHealth;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    public int GetCurrentHealth()
    {
        return currentHealth;
    }

    public void Daño(int daño)
    {
        currentHealth -= daño;
        if(currentHealth <= 0)
        {
            GameOver();
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Recibe Daño");
            Daño(25);
        }
    }

    private void GameOver()
    {
        Destroy(gameObject);
    }
}
