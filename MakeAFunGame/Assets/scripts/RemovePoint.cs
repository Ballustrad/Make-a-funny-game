using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemovePoint : MonoBehaviour
{
    public ScoreManager scoreManager;
    public Color startColor = Color.red;

    private Renderer newrenderer;
    public GameObject particleEffect;
    public float particleDuration = 2f;

    private void Start()
    {
        scoreManager = FindObjectOfType<ScoreManager>();
        newrenderer = GetComponent<Renderer>();
        newrenderer.material.color = startColor;
    }
    private void OnMouseDown()
    {
        scoreManager.RemovePoints(200);
        GameObject particle = Instantiate(particleEffect, transform.position, Quaternion.identity);

        Destroy(particle, particleDuration);
        Destroy(gameObject);
    }
}
