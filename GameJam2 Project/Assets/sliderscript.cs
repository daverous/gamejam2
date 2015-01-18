using UnityEngine;
using System.Collections;

public class sliderscript : MonoBehaviour {

	// Use this for initialization
    public UnityEngine.UI.Slider mySlider;
    public PlayerScript player;
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        mySlider.value = player.size.x * 10; 
	}
}
