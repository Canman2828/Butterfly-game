using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int butterflyCount = 0;
    public int butterfliesToWin = 10;
    private bool gameEnded = false;

    void Start()
    {
        Debug.Log("Collect butterflies to win!");
    }

    public void CollectButterfly()
    {
        butterflyCount++;
        Debug.Log("Butterflies collected: " + butterflyCount);

        if (butterflyCount >= butterfliesToWin && !gameEnded)
        {
            EndGame();
        }
    }

    public void EndGame()
    {
        gameEnded = true;
        Debug.Log("You collected all the butterflies! Game Over!");
        // You can load a new scene or show a UI here
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
