using UnityEngine;
using System.Collections;

public class UI : MonoBehaviour {
	public Animation anim;
	// Use this for initialization
	void Start () {
			/*anim = GetComponent<Animation>();
			anim.playAutomatically = false;*/
	}
	
	void OnMouseDown()
     {
         if(gameObject.tag == "PauseButton"){
             if(Time.timeScale == 1.0f)
            {
                Time.timeScale = 0;
                
            } else if (Time.timeScale == 0){
                Time.timeScale = 1;
                
            }
          }
     }

	// Update is called once per frame
	void Update () {
			/*anim = GetComponent<Animation>();
			anim.playAutomatically = false;*/
			
	}
}
