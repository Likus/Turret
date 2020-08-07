using UnityEngine;

public class AddScoreOnDestroy : MonoBehaviour
{
    [SerializeField] private int score;

    private void OnDestroy()
    {
        ScoreCounter.inst?.AddScore(score);
    }
}
