﻿using UnityEngine;
using System.Collections;

public class FlameLook : MonoBehaviour {

	public GameObject player;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.LookAt (player.transform.position);
	}
}
