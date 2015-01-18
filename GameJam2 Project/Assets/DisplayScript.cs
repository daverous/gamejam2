using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DisplayScript : MonoBehaviour
{

    int score;
    // Use this for initialization
    void Start()
    {

        score = ScoreScript.getScore();
        GetComponent<Text>().text = "Your Score is: " + score.ToString();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Application.LoadLevel("mainscene");
        }
    }
}