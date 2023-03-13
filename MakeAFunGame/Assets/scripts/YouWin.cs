using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YouWin : MonoBehaviour
{
    public GameObject winPanel;
    public menu Menu;
    public void Youwin()
    {
        winPanel.SetActive(false);
        Menu.MainMenu.SetActive(true);
        
    }
    
}
