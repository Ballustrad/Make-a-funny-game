using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu : MonoBehaviour
{
    public GameObject MainMenu;
    public bool paused = true;
    public GameObject winPanel;
    public Spawner spawner;

    public void Pause()
    {
        if (paused == true)
        {
            Time.timeScale = 0f;
        }
        else
        {
            Time.timeScale = 1f;
        }

    }

    public void Play()
    {
        spawner.LaunchGame();
        paused = false;
        MainMenu.SetActive(false);
    }
    
    public void Win()
    {
        spawner.StopAllCoroutines();
        winPanel.SetActive(true);
    }

    public void Quit()
    {
        Application.Quit();
    }

}
