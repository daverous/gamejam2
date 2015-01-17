using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	public float Speed = 5;
	public Vector3 dest;
	public GameObject player;
	bool playerInRange = false;
	CharacterController controller;
	
	void Start () {
		controller = this.GetComponent<CharacterController>();
		int destination = Random.Range (-13, -107);
		dest = new Vector3(-230, 1, destination);
	}
	
	void Update () {
		var step = Speed * Time.deltaTime;
		transform.position = Vector3.MoveTowards(transform.position, dest, step);
	}

	void OnControllerColliderHit(ControllerColliderHit collider)
	{
		if (collider.collider.gameObject.tag == "House")
		{
			Debug.Log("Enemy collided with house");
			//FindObjectOfType<GameManager>().GoToGameOverScreen("The flame sprites ate your brains!");
		}
	}

	void OnTriggerEnter (Collider other)
	{
		if(other.gameObject.tag == "Player")
		{
			Destroy(gameObject);
		}
	}


}
