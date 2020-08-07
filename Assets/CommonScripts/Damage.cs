using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Damage : MonoBehaviour
{
    public int damageCount;

    private void OnCollisionEnter(Collision collision)
    {
        Damageable target = collision.gameObject.GetComponent<Damageable>();
        if(target != null)
        {
            target.GetDamage(damageCount);
        }
    }
}
