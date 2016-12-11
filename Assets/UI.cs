using UnityEngine;
using System.Collections;

public class UI : MonoBehaviour {
	public GameObject pauseMenu, paused, resume, options, mainMenu;
	// Use this for initialization
	void Start () {
			/*anim = GetComponent<Animation>();
			anim.playAutomatically = false;*/
			pauseMenu = GameObject.Find("PauseMenu");
			paused = GameObject.Find("Paused");
			resume = GameObject.Find("Resume");
			options = GameObject.Find("Options");
			mainMenu = GameObject.Find("MainMenu");
			pauseMenu.GetComponent<Renderer>().enabled = false;
			paused.GetComponent<Renderer>().enabled = false;
			resume.GetComponent<Renderer>().enabled = false;
			options.GetComponent<Renderer>().enabled = false;
			mainMenu.GetComponent<Renderer>().enabled = false;
	}
	
	void OnMouseDown()
     {
     	//Animator anim = GetComponent<Animator>();
     	pauseMenu = GameObject.Find("PauseMenu");
     	paused = GameObject.Find("Paused");
			resume = GameObject.Find("Resume");
			options = GameObject.Find("Options");
			mainMenu = GameObject.Find("MainMenu");
     	//made object a collider first and tagged it
         if(gameObject.tag == "PauseButton"){
             if(Time.timeScale == 1)
            {
                Time.timeScale = 0;
                pauseMenu.GetComponent<Renderer>().enabled = true;
                paused.GetComponent<Renderer>().enabled = true;
								resume.GetComponent<Renderer>().enabled = true;
								options.GetComponent<Renderer>().enabled = true;
								mainMenu.GetComponent<Renderer>().enabled = true;
                
            } else if (Time.timeScale == 0){
                Time.timeScale = 1;
                pauseMenu.GetComponent<Renderer>().enabled = false;
                paused.GetComponent<Renderer>().enabled = false;
								resume.GetComponent<Renderer>().enabled = false;
								options.GetComponent<Renderer>().enabled = false;
								mainMenu.GetComponent<Renderer>().enabled = false;
            }
          }
     }

	// Update is called once per frame
	void Update () {
			/*anim = GetComponent<Animation>();
			anim.playAutomatically = false;*/
			/*if(Time.timeScale == 0)
			  {
			      pauseMenu.GetComponent<Renderer>().enabled = true;
			  } else if (Time.timeScale == 1){
			      pauseMenu.GetComponent<Renderer>().enabled = false;
			  }*/
	}
}
