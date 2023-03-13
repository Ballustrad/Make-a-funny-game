using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject objectPrefab;
    public float zoneRange = 5;
    public float delay = .5f;

    private void Start()
    {
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        Vector3 randomPosition = new Vector3(
            transform.position.x + Random.Range(-zoneRange, zoneRange),
            transform.position.y + 1f,
            transform.position.z + Random.Range(-zoneRange, zoneRange));
        Instantiate(objectPrefab, randomPosition, Quaternion.identity);
        yield return new WaitForSeconds(delay);
        StartCoroutine(Spawn());
    }
}
