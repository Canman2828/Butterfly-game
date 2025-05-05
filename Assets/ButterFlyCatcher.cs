using UnityEngine;
using TMPro;  // <- IMPORTANT for TextMeshPro

public class ButterflyCatcher : MonoBehaviour
{
    public TextMeshProUGUI scoreText;  // <- Change to TextMeshProUGUI
    private int score = 0;

    void Start()
    {
        UpdateScoreText();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Butterfly"))
        {
            Destroy(other.gameObject);
            score++;
            UpdateScoreText();
        }
    }

    void UpdateScoreText()
    {
        scoreText.text = "Butterflies Caught: " + score;
    }
}
