using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenuController : MonoBehaviour
{
    public GameObject pauseMenuCanvas;
    public Slider volumeSlider;
    public AudioSource musicSource; // assign your music player AudioSource here

    private bool isPaused = false;

    void Start()
    {
        // Ensure music continues playing when the game is paused
        if (musicSource != null)
        {
            musicSource.ignoreListenerPause = true;
        }
    }

    void Update()
    {
        // Controller button detection (check if Oculus SDK is available)
#if UNITY_ANDROID && UNITY_EDITOR || UNITY_STANDALONE
        if (OVRInput.GetDown(OVRInput.Button.Start)) // Oculus Start Button
        {
            TogglePause();
        }
#endif
    }

    public void TogglePause()
    {
        isPaused = !isPaused;
        pauseMenuCanvas?.SetActive(isPaused);

        Time.timeScale = isPaused ? 0f : 1f; // Pause/unpause game time
    }

    public void ResumeGame()
    {
        isPaused = false;
        pauseMenuCanvas?.SetActive(false);
        Time.timeScale = 1f;
    }

    public void ChangeMap()
    {
        // Example: Just reload the current scene for now
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        // Later you can load different scenes (maps) like:
        // SceneManager.LoadScene("Map2SceneName");
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void SetVolume(float volume)
    {
        if (musicSource != null)
        {
            musicSource.volume = volume;
        }
    }
}
