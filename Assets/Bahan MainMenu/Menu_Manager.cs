using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu_Manager : MonoBehaviour
{
    public GameObject MenuPanel;
    public GameObject CreditsPanel;
    public GameObject InstruksiPanel;

    // Start is called before the first frame update
    void Start()
    {
        MenuPanel.SetActive(true);
        CreditsPanel.SetActive(false);
        InstruksiPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayButtonClicked()
    {
        Application.LoadLevel("Labirin");
    }
    public void CreditsButtonClicked()
    {
        MenuPanel.SetActive(false);
        CreditsPanel.SetActive(true);
        InstruksiPanel.SetActive(false);
    }
    public void InstruksiButtonClicked()
    {
        MenuPanel.SetActive(false);
        CreditsPanel.SetActive(false);
        InstruksiPanel.SetActive(true);
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
    }
}
