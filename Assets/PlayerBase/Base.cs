using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class Base : MonoBehaviour
{
    [SerializeField] private Text uiHp;
    [SerializeField] private int hp;
    [SerializeField] private UnityEvent onZeroHp;

    private void Start()
    {
        ResetHp();
    }

    public void ResetHp()
    {
        hp = 100;
        UpdateUI();
    }

    public void Damage(int count)
    {
        hp -= count;
        UpdateUI();
        if (hp <= 0)
        {
            onZeroHp?.Invoke();
        }
    }
    public void UpdateUI()
    {
        uiHp.text = hp.ToString();
    }
}
