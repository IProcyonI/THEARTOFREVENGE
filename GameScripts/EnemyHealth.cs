using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int health;

    public void Update()
    {       

        if (health <= 0) 
        {
            Destroy(gameObject);
        }
    }
}
