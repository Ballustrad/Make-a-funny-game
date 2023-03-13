using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject objectPrefab;
    public GameObject objectPrefab2;
    public float zoneRange = 5;
    public float delay = 1f;
    public float delay2 = .10f;
    public float lifetime = 2f;
    public float lifetime2 = 3f;

    public void LaunchGame()
    {
        StartCoroutine(Spawn());
        StartCoroutine(Spawn2());
    }
    

    IEnumerator Spawn()
    {
        Vector3 randomPosition = new Vector3(
            transform.position.x + Random.Range(-zoneRange, zoneRange),
            transform.position.y + 1f,
            transform.position.z + Random.Range(-zoneRange, zoneRange));
        GameObject newObject = Instantiate(objectPrefab, randomPosition, Quaternion.identity);
        Destroy(newObject, lifetime);
        yield return new WaitForSeconds(delay);
        StartCoroutine(Spawn());
    }
    IEnumerator Spawn2()
    {
        Vector3 randomPosition = new Vector3(
            transform.position.x + Random.Range(-zoneRange, zoneRange),
            transform.position.y + 1f,
            transform.position.z + Random.Range(-zoneRange, zoneRange));
        GameObject newObject2 = Instantiate(objectPrefab2, randomPosition, Quaternion.identity);
        Destroy(newObject2, lifetime);
        yield return new WaitForSeconds(delay2);
        StartCoroutine(Spawn2());
    }
}


