using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScreenController : MonoBehaviour
{
    [SerializeField] public string sceneRestart;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            OnBackHub();
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            OnRestart();
        }
    }

    public void EnableGameOverScreen()
    {
        AudioListener.volume = 0f;
        Time.timeScale = 0f;
        gameObject.SetActive(true);
    }





    public void OnRestart()
    {
        AudioListener.volume = 1f;
        Time.timeScale = 1f;
        SceneManager.LoadScene(sceneRestart);
    }

    public void OnBackHub()
    {
        AudioListener.volume = 1f;
        Time.timeScale = 1f;
        SceneManager.LoadScene("Hub");
    }
}
