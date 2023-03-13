using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPoints : MonoBehaviour
{
    public ScoreManager scoreManager;

    private void Start()
    {
        scoreManager = FindObjectOfType<ScoreManager>();
    }
    private void OnMouseDown()
    {
        scoreManager.AddPoints(50);
        Destroy(gameObject);
    }
}
