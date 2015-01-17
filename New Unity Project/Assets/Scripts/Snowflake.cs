using UnityEngine;
using System.Collections;

public class Snowflake : MonoBehaviour {

    Vector3 TargetPosition;
    Vector3 CurrentPosition;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {

        if ((TargetPosition - CurrentPosition).magnitude <= 0.05) {
            Disintegrate();
        }

	}

    private void Disintegrate()
    {
        throw new System.NotImplementedException();
    }
}
