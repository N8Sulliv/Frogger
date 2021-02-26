using UnityEngine;

public class SpawnBird : MonoBehaviour
{
    public float timeBetweenSpawns = .3f;

    float countdownTimer = 1f;

    public GameObject bird;

    public Transform[] spawnPoints;

    private void Update()
    {
        if (countdownTimer <= 0f)
        {
            SpawnCar();
            countdownTimer = .25f;
        }
        else
        {
            countdownTimer -= Time.deltaTime;
        }
    }

    void SpawnCar()
    {
        int randomIndex = Random.Range(0, spawnPoints.Length);
        Transform spawnPoint = spawnPoints[randomIndex];
        Instantiate(bird, spawnPoint.position, spawnPoint.rotation);
    }
}
