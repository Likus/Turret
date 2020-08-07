using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;

[RequireComponent(typeof(NavMeshAgent))]
public class SetNavMeshTarget : MonoBehaviour
{
    NavMeshAgent agent;

    public Transform target;
    public bool destroyInTarget;
    public float areaTarget;

    [SerializeField] private UnityEvent onTarget;

    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    private void Start()
    {
        if(target != null)
        {
            agent.destination = target.position;
        }
    }

    private void Update()
    {
        if(destroyInTarget)
        {
            if(Vector3.Distance(transform.position, target.position) < areaTarget)
            {
                onTarget.Invoke();
                Destroy(gameObject);
            }
        }
    }
}
