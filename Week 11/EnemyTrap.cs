using UnityEngine;

public class HealthTrap : MonoBehaviour
{
    public GameObject TrapEnemy;
    public GameObject ETrap;

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
        if (other.CompareTag("Player"))
        {
            ETrap.SetActive(false);
            TrapEnemy.SetActive(true);
        }
    }
}

