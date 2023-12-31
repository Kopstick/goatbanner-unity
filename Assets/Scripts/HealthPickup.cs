using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickup : MonoBehaviour
{
    public int healthRestore = 20;
    public PlayerHealth playerHealth;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(GameObject.FindWithTag("Player")  != null)
        { 
            if(playerHealth.health != playerHealth.maxHealth)
            {
                playerHealth.health += healthRestore;
                Destroy(gameObject);
            }
        }
        
    }
}
