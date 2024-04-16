using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalSpanning : MonoBehaviour
{
    [SerializeField]
    private GameObject[] animalPrefabs;

    [SerializeField]
    private GameObject spawnArea;

    [SerializeField]
    private float spawnDelay = 1f;


    private float timeLeft;

    private Vector3 spawnLine; // x1, x2, z : start, end, offset
    // Start is called before the first frame update
    void Start()
    {
        float spawnAreaWidth = spawnArea.transform.localScale.x;
        float spawnAreaXOrigin = spawnArea.transform.position.x - spawnAreaWidth / 2;

        spawnLine = new(spawnAreaXOrigin, spawnAreaXOrigin + spawnAreaWidth, spawnArea.transform.position.z);

        timeLeft = spawnDelay;
    }

    // Update is called once per frame
    void Update()
    {

        timeLeft -= Time.deltaTime;

        if (timeLeft <= 0) {
            SpawnAnimal();
            timeLeft = spawnDelay;
        }
        
    }

    private void SpawnAnimal() {
        Vector3 spawnPosition = new(Random.Range(spawnLine.x, spawnLine.y), 0, spawnLine.z);
        Quaternion spawnParameters = Quaternion.Euler(0, 180, 0);
        Instantiate(GetRandomPrefab(), spawnPosition, spawnParameters);
    }


    private GameObject GetRandomPrefab() {
        int randomIndex = Random.Range(0, animalPrefabs.Length);
        return animalPrefabs[randomIndex];
    }
}
