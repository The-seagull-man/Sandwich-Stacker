using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseScreen : MonoBehaviour
{
    public Canvas pauseScreenCanvas;
    void Start()
    {
        Time.timeScale = 1.0f;
        pauseScreenCanvas.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (pauseScreenCanvas.gameObject.activeSelf == true)
            {
                ReturnFromPause();
            }
            else
            {
                Pause();
            }
        }
    }

    public void ReturnFromPause()
    {
        pauseScreenCanvas.gameObject.SetActive(false);
        Time.timeScale = 1.0f;

    }

    public void Pause()
    {
        pauseScreenCanvas.gameObject.SetActive(true);
        Time.timeScale = 0;
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
