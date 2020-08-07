using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    public static ScoreCounter inst;

    [SerializeField] private Text uiScore;

    private int score;

    private void Awake()
    {
        inst = this;
    }

    private void Start()
    {
        ResetScore();
    }

    private void ResetScore()
    {
        score = 0;
        UpdateUI();
    }

    public void AddScore(int count)
    {
        score += count;
        UpdateUI();
    }

    public void UpdateUI()
    {
        uiScore.text = score.ToString();
    }
}
