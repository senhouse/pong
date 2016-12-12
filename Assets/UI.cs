using UnityEngine;
using System.Collections;

public class UI : MonoBehaviour {
	public GameObject pauseParent, pauseMenu, paused, options, mainMenu;
	public bool gamePaused;
	// Use this for initialization
	void Start () {
			/*anim = GetComponent<Animation>();
			anim.playAutomatically = false;*/
			pauseMenu = GameObject.Find("PauseMenu");
			paused = GameObject.Find("Paused");
			//resume = GameObject.Find("Resume");
			options = GameObject.Find("Options");
			mainMenu = GameObject.Find("MainMenu");
			//pauseMenu.SetActive(false);
			/*paused.SetActive(false);
			resume.SetActive(false);
			options.SetActive(false);
			mainMenu.SetActive(false);*/
	}
	
	void OnMouseDown()
     {
     	//Animator anim = GetComponent<Animator>();
     	/*pauseMenu = GameObject.Find("PauseMenu");
     	paused = GameObject.Find("Paused");
			resume = GameObject.Find("Resume");
			options = GameObject.Find("Options");
			mainMenu = GameObject.Find("MainMenu");*/
     	//made object a collider first and tagged it
         if(gameObject.tag == "PauseButton"){
             if(Time.timeScale > 0)
            {
                Time.timeScale = 0;
                gamePaused = true;
                //pauseMenu.SetActive(true);
                /*paused.SetActive(true);
								resume.SetActive(true);
								options.SetActive(true);
								mainMenu.SetActive(true);*/
                
            } else if (Time.timeScale == 0){
                Time.timeScale = 1;
                gamePaused = false;
                //pauseMenu.SetActive(false);
                /*paused.SetActive(false);
								resume.SetActive(false);
								options.SetActive(false);
								mainMenu.SetActive(false);*/
            }
          } else if(gameObject.tag == "Resume"){
          			Time.timeScale = 1;
          			gamePaused = false;
                //pauseMenu.SetActive(false);
                /*paused.SetActive(false);
								resume.SetActive(false);
								options.SetActive(false);
								mainMenu.SetActive(false);*/
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
			  pauseParent = GameObject.Find("PauseParent");
			  foreach (Transform child in pauseParent.transform)
         {
             if (Time.timeScale > 0) {
                 child.gameObject.SetActive(false);
             }
             else if (Time.timeScale == 0 && gamePaused){
                 child.gameObject.SetActive(true);
             }
         }
	}
}
