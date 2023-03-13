using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    

    private int playerScore = 0;

    public TextMeshProUGUI score;

    public void AddPoints(int value)
    {
        playerScore = playerScore + value;
        score.text = playerScore.ToString();
        //CheckScore();//
    }

    public void RemovePoints(int value)
    {
        playerScore = playerScore - value;
        score.text = playerScore.ToString();
        //CheckScore();//
    }

    /*private void CheckScore()
    {
        if (player1Score == scoreToReach)
        {
            SceneManager.LoadScene(3);
        }
        else if (player2Score == scoreToReach)
        {
            SceneManager.LoadScene(2);
        }
    }*/
}
