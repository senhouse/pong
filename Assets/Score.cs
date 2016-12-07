using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {

	public GameObject Score1DoubDig, Score1TopL, Score1Top, Score1TopR, Score1Mid, Score1BottomL, Score1Bottom, Score1BottomR, Score2DoubDig, Score2TopL, Score2Top, Score2TopR, Score2Mid, Score2BottomL, Score2Bottom, Score2BottomR;

	// Use this for initialization
	void Start () {
		Score1DoubDig = GameObject.Find("Score1DoubDig");
		Score1Mid = GameObject.Find("Score1Mid");
		Score1DoubDig.GetComponent<Renderer>().enabled = false;
		Score1Mid.GetComponent<Renderer>().enabled = false;
		Score2DoubDig = GameObject.Find("Score2DoubDig");
		Score2Mid = GameObject.Find("Score2Mid");
		Score2DoubDig.GetComponent<Renderer>().enabled = false;
		Score2Mid.GetComponent<Renderer>().enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
