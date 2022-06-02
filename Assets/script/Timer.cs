using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    float currentTime = 0f;
    public float startingTime;
    public GameObject WinPanel;
    public GameObject OverPanel;

    [SerializeField] public TextMeshProUGUI countdownText;

    void Start()
    {
        currentTime = startingTime;
    }

    void Update()
    {
        
         if (WinPanel.activeSelf)
         {
            currentTime = currentTime;
         }else{
            currentTime -= 1 * Time.deltaTime;
            countdownText.text = currentTime.ToString("0");
         }
        if (currentTime <= 0)
        {
            currentTime = 0;
            OverPanel.SetActive(true);
        }
    }
}