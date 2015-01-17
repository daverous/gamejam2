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
        InvokeRepeating("Spawn", spawnTime1, spawnTime1);
        InvokeRepeating("Spawn", spawnTime2, spawnTime2);
        InvokeRepeating("Spawn", spawnTime3, spawnTime3);
	}
	
	
	void Spawn ()
	{
		
		int spawnPointIndex = Random.Range (0, spawnPoints.Length);
        while (spawnPointIndex == lastIndex)
        {
            spawnPointIndex = Random.Range(0, spawnPoints.Length);
        }
        
        float num = Random.Range(0F, 3F);
        if (num < 1)
        {
            Instantiate(enemy1, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
        }
        else if (num < 2)
        {
            Instantiate(enemy2, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
        }
        else if (num < 3)
        {
            Instantiate(enemy3, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
        }
        lastIndex = spawnPointIndex;
    }
}
