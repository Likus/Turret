using UnityEngine;

public class DamageBase : MonoBehaviour
{
    [SerializeField] private int damage;

    private Base target;

    private void Start()
    {
        target = FindObjectOfType<Base>();
    }

    public void OnTarget()
    {
        target.Damage(damage);
    }
}
