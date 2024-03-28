using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileGenerator : MonoBehaviour
{

    public GameObject[] tilePrefabs;
    private float spawnPos = 0;
    private float tileLength = 100;

    [SerializeField] private Transform player;
    private int startTiles = 6;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < startTiles; i++)
        {
            SpawnTile(Random.Range(0, tilePrefabs.Length));
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SpawnTile(int tileIndex)
    {
        Instantiate(tilePrefabs[tileIndex], transform.forward * spawnPos, transform.rotation);
        spawnPos += tileLength;
    }
}
