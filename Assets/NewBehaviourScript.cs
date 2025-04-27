using UnityEngine;
using UnityEngine.SceneManagement;

public class ButterflyCatcher : MonoBehaviour
{
    public int butterfliesCaught = 0;
    public int targetCount = 10;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Butterfly"))
        {
            butterfliesCaught++;
            Destroy(other.gameObject); // remove butterfly from scene

            if (butterfliesCaught >= targetCount)
            {
                LoadNextScene();
            }
        }
    }

    void LoadNextScene()
    {
        int currentIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentIndex + 1); // loads the next scene in Build Settings
    }
}
