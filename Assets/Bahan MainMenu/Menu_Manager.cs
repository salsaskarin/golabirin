using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_Manager : MonoBehaviour
{
    public GameObject MenuPanel;
    public GameObject CreditsPanel;
    public GameObject InstruksiPanel;
    public GameObject LevelPanel;

    // Start is called before the first frame update
    void Start()
    {
        MenuPanel.SetActive(true);
        CreditsPanel.SetActive(false);
        InstruksiPanel.SetActive(false);
        LevelPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayButtonClicked()
    {
        SceneManager.LoadScene("Labirin");
    }
    public void CreditsButtonClicked()
    {
        MenuPanel.SetActive(false);
        CreditsPanel.SetActive(true);
        InstruksiPanel.SetActive(false);
        LevelPanel.SetActive(false);
    }
    public void InstruksiButtonClicked()
    {
        MenuPanel.SetActive(false);
        CreditsPanel.SetActive(false);
        InstruksiPanel.SetActive(true);
        LevelPanel.SetActive(false);
    }
    public void LevelButtonClicked()
    {
        MenuPanel.SetActive(false);
        CreditsPanel.SetActive(false);
        InstruksiPanel.SetActive(false);
        LevelPanel.SetActive(true);
    }
    public void SatuButtonClicked()
    {
        SceneManager.LoadScene("Labirin");
    }
    public void DuaButtonClicked()
    {
        SceneManager.LoadScene("Labirin 2");
    }
    public void Quit_Clicked()
    {
        Application.Quit();
    }
    public void BackButtonClicked()
    {
        MenuPanel.SetActive(true);
        CreditsPanel.SetActive(false);
        InstruksiPanel.SetActive(false);
        LevelPanel.SetActive(false);
    }
}
