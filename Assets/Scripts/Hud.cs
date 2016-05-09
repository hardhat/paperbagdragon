using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Hud : MonoBehaviour {
    public int score;
    public int target;
    public Text scoreText;

	// Use this for initialization
	void Start () {
        target = 10;
        score = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void recordTreeHit()
    {
        score++;
        scoreText.text = "" + score + " of " + target;
    }
}
