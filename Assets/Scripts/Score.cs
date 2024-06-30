using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public static int score = 0;
    private void Start()
    {
        score = 0;
    }
    private void Update()
    {
        scoreText.text = score.ToString();
    }
}
