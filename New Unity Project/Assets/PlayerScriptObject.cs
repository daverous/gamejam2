using UnityEngine;
using System.Collections;

public class PlayerScriptObject : MonoBehaviour {

	public GameObject player;
	Vector3 point;

	// Use this for initialization
	void Start () {
		point = transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () {
		transform.position = player.transform.position + point;
		this.transform.Rotate(new Vector3(0, Input.GetAxis("Horizontal"), 0));
		 
	}
}
