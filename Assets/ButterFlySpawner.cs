using UnityEngine;

public class ButterflySpawner : MonoBehaviour
{
    public GameObject butterflyPrefab;
    public int numberOfButterflies = 40;
    public float spawnRadius = 50f;
    public float minHeight = 0.5f;  // minimum height (off the ground)
    public float maxHeight = 1.8f;  // maximum height (about average head height in meters)

    void Start()
    {
        for (int i = 0; i < numberOfButterflies; i++)
        {
            Vector3 randomPos = transform.position + Random.insideUnitSphere * spawnRadius;
            randomPos.y = Random.Range(minHeight, maxHeight);  // Clamp to head level
            Instantiate(butterflyPrefab, randomPos, Quaternion.identity);
        }
    }
}
