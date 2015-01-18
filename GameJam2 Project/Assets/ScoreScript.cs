using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour {

    static int score;
    Text instruction;
	// Use this for initialization
	void Start () {
        instruction = GetComponent<Text>();
        score = 0;
	}
	
	// Update is called once per frame
	void Update () {
        instruction.text = score.ToString();
	}

    public void increaseScore()
    {
        score++;
    }
    public static int getScore()
    {
        return score;
    }
}
