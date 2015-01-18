using UnityEngine;

public class Controller : MonoBehaviour
{
	public GameObject enemy1;
    public GameObject enemy2;
    public GameObject enemy3;
    public float spawnTime1 = 7f;
    public float spawnTime2 = 8f;
    public float spawnTime3 = 9f;
	public Transform[] spawnPoints;
    int lastIndex = 0;
	
	void Start ()
	{
        InvokeRepeating("Spawn1", spawnTime1, spawnTime1);
        InvokeRepeating("Spawn2", spawnTime2, spawnTime2);
        InvokeRepeating("Spawn3", spawnTime3, spawnTime3);
	}
	
	
	void Spawn1 ()
	{
		int spawnPointIndex = Random.Range (0, spawnPoints.Length);
		while (spawnPointIndex == lastIndex)
		{
			spawnPointIndex = Random.Range(0, spawnPoints.Length);
		}
        Instantiate(enemy1, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
        lastIndex = spawnPointIndex;
    }

	void Spawn2 ()
	{
		int spawnPointIndex = Random.Range (0, spawnPoints.Length);
		while (spawnPointIndex == lastIndex)
		{
			spawnPointIndex = Random.Range(0, spawnPoints.Length);
		}
		Instantiate(enemy2, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
		lastIndex = spawnPointIndex;
	}

	void Spawn3 ()
	{
		int spawnPointIndex = Random.Range (0, spawnPoints.Length);
		while (spawnPointIndex == lastIndex)
		{
			spawnPointIndex = Random.Range(0, spawnPoints.Length);
		}
		Instantiate(enemy3, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
		lastIndex = spawnPointIndex;
	}
}
