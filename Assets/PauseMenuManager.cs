using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class PauseMenuManager : MonoBehaviour
{
    public GameObject pauseMenuUI;
    public Slider volumeSlider;
    public XRRayInteractor rightHandRay; // assign this in Inspector
    public LineRenderer rightHandLine;    // assign this in Inspector

    private bool isPaused = false;

    void Start()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
    }

    void Update()
    {
        // If B button OR P key is pressed
        if (Input.GetKeyDown(KeyCode.JoystickButton1) || Input.GetKeyDown(KeyCode.P))
        {
            if (isPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;

        if (rightHandRay != null) rightHandRay.enabled = false;
        if (rightHandLine != null) rightHandLine.enabled = false;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;

        if (rightHandRay != null) rightHandRay.enabled = true;
        if (rightHandLine != null) rightHandLine.enabled = true;
    }

    public void ChangeMap()
    {
        // Temporary placeholder for changing maps
        Debug.Log("Change Map clicked - feature coming soon!");
    }

    public void ExitGame()
    {
        Debug.Log("Exiting Game...");
        Application.Quit();
    }

    public void AdjustVolume(float volume)
    {
        AudioListener.volume = volume;
    }
}