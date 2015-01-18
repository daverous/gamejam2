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



	void OnTriggerEnter (Collider other)
	{
		if(other.gameObject.tag == "Player")
		{
         
			Destroy(gameObject);
		}

        if (other.gameObject.tag == "House")
        {
            Debug.Log("GOOOD1");
            Application.LoadLevel("GameOver");
        }
	}


}
