using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    private int streak;

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "0";
        streak = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int UpdateScore(bool correctAnswer)
    {
        streak = correctAnswer ? streak + 1 : 0;
        scoreText.text = (int.Parse(scoreText.text) + streak).ToString();

        return streak;
    }
}
