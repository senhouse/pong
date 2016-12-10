using UnityEngine;
using System.Collections;

public class AI : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GameObject ball = GameObject.Find("Ball");
		Ball ballscript = ball.GetComponent<Ball>();
		//sets ai to start racket direction randomly
		Vector3 pos = transform.position;
    pos.y = Random.Range(-2, 2);
    //ensures racket doesnt start at middle zero pos
    Vector3 badPos = new Vector3 (23,0,0);
    if (pos == badPos){
    	Vector3 goodPos = new Vector3 (23,2,0);
    	transform.position = goodPos;
    } else {
    	transform.position = pos;
    }
	}
	
	// Update is called once per frame
	void Update () {
		//references ball
		GameObject ball = GameObject.Find("Ball");
		Ball ballscript = ball.GetComponent<Ball>();
		//locks racket to y axis
		Vector3 pos = transform.position;
    pos.z = 0;
    pos.x = 23;
    transform.position = pos;
    //determines ball's position from racket
		Vector3 direction = ball.transform.position - transform.position;
		//allows vector3 data to be used in below equation
		direction.Normalize();
		//ai follow algorithm, speed is half of the ball movement speed
		transform.position += direction * Time.deltaTime * ballscript.speed / 2;
	}
}
