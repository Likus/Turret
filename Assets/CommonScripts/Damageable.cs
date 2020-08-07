using UnityEngine;

public class Damageable : MonoBehaviour
{
    public int healthCount;

    public bool destroyOnZeroHealth;

    public void GetDamage(int count)
    {
        healthCount -= count;
        if(destroyOnZeroHealth)
        if(healthCount <= 0)
        {
                Destroy(gameObject);
        }
    }
}
