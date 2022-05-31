using UnityEngine.SceneManagement;
using UnityEngine;

public class events : MonoBehaviour
{
    public void ReplayGame()
    {
        SceneManager.LoadScene("Labirin");
    }
    public void BackToMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
    /*
    public void NextGame2()
    {
        SceneManager.LoadScene("Labirin 2");
    }
    */
}