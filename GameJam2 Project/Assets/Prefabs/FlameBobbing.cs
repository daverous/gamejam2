using UnityEngine;
using System.Collections;

public class FlameBobbing : MonoBehaviour {

	Vector3 flamePos;
	int flameCounter; //-5 <> 5
	bool flameDir; //true = up, false = down
	public int speed;

	// Use this for initialization
	void Start () {
		flamePos = transform.position;
		flameCounter = 0;
		flameDir = true;
	}
	
	// Update is called once per frame
	void Update () {
				//change flame position
				//if (flameCounter <= 5)
		if (flameDir == true) {//going up
			if (flameCounter <= 5) {
				flamePos = flamePos + Vector3.up * Time.deltaTime * speed;
				flameCounter ++;
			} else {
				flameDir = false;
			}
		} else { //going down
			if (flameCounter >= -5) {
				flamePos = flamePos + Vector3.down *Time.deltaTime * speed;
				flameCounter --;
			} else {
				flameDir = true;
			}		
		}

		//update position
		//transform.position = flamePos;
	}
}
