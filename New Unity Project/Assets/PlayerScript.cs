using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {
	
	// Use this for initialization
	public Vector3 size;
	public GameObject player;
	CharacterController controller;
	public float MAX_SIZE = 10F;
	public float MIN_SIZE = 0.5F;

	public float speed;

	void Start () {
		size = player.transform.localScale;
		controller = this.GetComponent<CharacterController>();
	}
	
	// Update is called once per frame


	void FixedUpdate () {
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		
		rigidbody.AddForce (movement * speed * Time.deltaTime);
		
		if (!rigidbody.IsSleeping()) {
			if (size.x < MAX_SIZE && size.z < MAX_SIZE && size.y < MAX_SIZE)
			{
				size += new Vector3(0.001F, 0.001F, 0.001F);
				Debug.Log(size.x);
				player.transform.localScale = size;
				
				
				controller.center = player.transform.position;
			}
		}
	}
	
	
	void OnControllerColliderHit(ControllerColliderHit collider)
	{
		if (collider.collider.gameObject.tag == "Finish")
		{
			Debug.Log("Player collided with enemy.");
			
			size -= new Vector3(0.5F, 0.5F, 0.5F);
			if (size.x < MIN_SIZE)
			{
				Debug.Log("GameOVER");
			}
			player.transform.localScale = size;
			controller.center = player.transform.position;
			
		}
	}
}
