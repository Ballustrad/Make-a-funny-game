using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    

    private int playerScore = 0;
    private bool milestoneSoundPlayed = false;
    public TextMeshProUGUI score;
    public AudioSource audioSource;
    public AudioClip nice;
    public AudioClip notnice;
    public AudioClip milestoneSound;
    public int milestone = 1000;
    public int targetScore = 4000;
    public menu Menu;

    private void Update()
    {
        // Vérifier si le joueur a atteint le score cible
        if (playerScore >= targetScore)
        {
            Menu.Win();
        }

        // Vérifier si le joueur a atteint un multiple de la valeur de jalon
        if (playerScore % milestone == 0 && playerScore != 0 && !milestoneSoundPlayed)
        {
            // Jouer le son de jalon
            audioSource.PlayOneShot(milestoneSound);
            milestoneSoundPlayed = true;
        }

        // Réinitialiser le marqueur de son de jalon si le score n'est plus un multiple de la valeur de jalon
        if (playerScore % milestone != 0)
        {
            milestoneSoundPlayed = false;
        }
    }


    public void AddPoints(int value)
    {
        audioSource.PlayOneShot(nice);
        playerScore = playerScore + value;
        score.text = playerScore.ToString();
        //CheckScore();//
    }

    public void RemovePoints(int value)
    {
        audioSource.PlayOneShot(notnice);
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
