using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {
	
	// Use this for initialization
	public Vector3 size;
	public GameObject player;
	CharacterController controller;
	public float MAX_SIZE = 10F;
	public float MIN_SIZE = 2F;

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
				size += new Vector3(0.003F, 0.003F, 0.003F);
				//Debug.Log(size.x);
				player.transform.localScale = size;
				
				
				controller.center = player.transform.position;
			}
		}
	}


    void OnTriggerEnter(Collider other)
	{
        Debug.Log("HERE");
		if (other.gameObject.tag == "Enemy_S")
		{
			Debug.Log("Player collided with enemy.");
			
			size -= new Vector3(1F, 1F, 1F);
			if (size.x < MIN_SIZE)
			{
                Application.Quit();
			}
			player.transform.localScale = size;
			controller.center = player.transform.position;
			
		}
        else if (other.gameObject.tag == "Enemy_M")
        {
            Debug.Log("Player collided with enemy.");

            size -= new Vector3(2F, 2F, 2F);
            if (size.x < MIN_SIZE)
            {
                Application.Quit();
            }
            player.transform.localScale = size;
            controller.center = player.transform.position;

        }

        else if (other.gameObject.tag == "Enemy_L")
        {
            Debug.Log("Player collided with enemy.");

            size -= new Vector3(3F, 3F, 3F);
            if (size.x < MIN_SIZE)
            {
                Application.Quit();
            }
            player.transform.localScale = size;
            controller.center = player.transform.position;

        }

	}
}
