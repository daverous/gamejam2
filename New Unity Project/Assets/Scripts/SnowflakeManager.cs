using UnityEngine;
using System.Collections;

public class SnowflakeManager : MonoBehaviour {

    public const int MAX_SNOWFLAKES = 10;
    public int CurrentNumberOfSnowflakes;
    public Vector3 spawnPoint;
    
	// Use this for initialization
	void Start () {
        CurrentNumberOfSnowflakes = 0;
	}
	
	// Update is called once per frame
	void Update () {

        if (CurrentNumberOfSnowflakes < MAX_SNOWFLAKES) {
            SpawnSnowflake();
            CurrentNumberOfSnowflakes++;
        }

	}

    private void SpawnSnowflake()
    {
        throw new System.NotImplementedException();
    }
}
