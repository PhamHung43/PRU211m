using System.Collections.Generic;
using UnityEngine;

public class BlockSpawner : MonoBehaviour {

	public Transform[] spawnPoints;

	public GameObject blockPrefab;

	public float timeBetweenWaves = 1.1f;

	private float timeToSpawn = 1f;

	void Update () {

		if (Time.time >= timeToSpawn)
		{
			SpawnBlocks();
			timeToSpawn = Time.time + timeBetweenWaves;
		}

	}

	void SpawnBlocks ()
	{
        List<int> rdList = new List<int>();
        int count = 0;

        while(count != 4)
        {
            int rdindex = Random.Range(0, spawnPoints.Length);
            if (!rdList.Contains(rdindex))
            {
                Instantiate(blockPrefab, spawnPoints[rdindex].position, Quaternion.identity);
                rdList.Add(rdindex);
                count++;
            }
        }

        


        //for (int i = 0; i < spawnPoints.Length; i++)
        //{
        //	if (randomIndex != i)
        //	{
        //		Instantiate(blockPrefab, spawnPoints[i].position, Quaternion.identity);
        //	}
        //}


    }
	
}
