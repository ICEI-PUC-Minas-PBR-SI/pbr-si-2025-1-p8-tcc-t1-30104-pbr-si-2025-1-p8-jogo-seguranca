using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] public float health;

    private PowerController powerController;

    private bool canDamage = true;

    public float maxHealth;
    
    void Start()
    {
        maxHealth = health;
        powerController = FindFirstObjectByType<PowerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0 && !gameObject.CompareTag("Cart"))
        {
            StopAllCoroutines();
            powerController.SetEnemyDestroy();
            Destroy(gameObject);         
        }
    }

    public void TakeDamage(float damage)
    {
        if(canDamage)
        {
            health -= damage;

        }
    }

    public void SetCanDamage(bool value)
    {
        canDamage = value;
    }


  


}
