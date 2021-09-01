using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(TankController))]
public class Player : MonoBehaviour
{
    [SerializeField] int maxHealth = 3;
    int currentHealth;

    TankController tankController;

    private void Awake()
    {
        tankController = GetComponent<TankController>();
    }

    private void Start()
    {
        currentHealth = maxHealth;
    }

    public void IncreaseHealth(int amount)
    {
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
        Debug.Log("Player's health: " + currentHealth);
    }

    public void DecreaseHealth(int amount)
    {
        currentHealth -= amount;
        Debug.Log("Player's health: " + currentHealth);
        if (currentHealth <= 0)
            Kill();
    }

    public void Kill()
    {
        gameObject.SetActive(false);
        //particles
        //sounds
    }
}
