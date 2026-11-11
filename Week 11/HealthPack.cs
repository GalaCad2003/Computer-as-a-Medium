using UnityEngine;

public class HealthPack : MonoBehaviour
{
    public PlayerHealth playerHealth;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (playerHealth.health == 100)
        {
            Destroy(gameObject);
        }
        else 
        {
            playerHealth.health += 10;

            Destroy(gameObject);
        }
    }

    

}
