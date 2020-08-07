using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class DestroyAfterCollide : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
}
