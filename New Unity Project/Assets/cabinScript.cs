using UnityEngine;
using System.Collections;

public class cabinScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("HOUSE HAS BEEN HIT!");
        if (other.gameObject.tag == "Enemy_S")
        {
                Application.Quit();
    
        }
        else if (other.gameObject.tag == "Enemy_M")
        {

                Application.Quit();
            }

        

        else if (other.gameObject.tag == "Enemy_L")
        {
            
                Application.Quit();
            }
           

    }
}
