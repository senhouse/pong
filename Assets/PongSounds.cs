using UnityEngine;
using System.Collections;

public class PongSounds:MonoBehaviour{

	void OnCollisionEnter2D(Collision2D col){
		if (col.collider.name == "Ball"){
			GetComponent<AudioSource>().Play();
		}
	}
}
