using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.ParticleSystem;

public class AddPoints : MonoBehaviour
{
    public ScoreManager scoreManager;
    public GameObject particleEffect;
    public float particleDuration = 2f;

    private void Start()
    {
        scoreManager = FindObjectOfType<ScoreManager>();
    }
    private void OnMouseDown()
    {
        
        scoreManager.AddPoints(50);
        GameObject particle = Instantiate(particleEffect, transform.position, Quaternion.identity);

        Destroy(particle, particleDuration);
        Destroy(gameObject);
    }
}
