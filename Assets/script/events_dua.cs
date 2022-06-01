using UnityEngine.SceneManagement;
using UnityEngine;

public class events_dua : MonoBehaviour
{
    public void ReplayGame()
    {
        SceneManager.LoadScene("Labirin 2");
    }
    public void BackToMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
}