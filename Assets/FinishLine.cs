using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    public GameObject WinPanel;


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            WinPanel.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}