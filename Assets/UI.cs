using UnityEngine;
using System.Collections;

public class UI : MonoBehaviour {
	public GameObject pauseParent, pauseMenu, paused, options, mainMenu;
	public bool gamePaused;
	public bool onePlayerGame = true;

	// Use this for initialization
	void Start () {
			pauseMenu = GameObject.Find("PauseMenu");
			paused = GameObject.Find("Paused");
			//resume = GameObject.Find("Resume");
			options = GameObject.Find("Options");
			mainMenu = GameObject.Find("MainMenu");
	}
	
	void OnMouseDown()
     {
     	//made object a collider first and tagged it
         if(gameObject.tag == "PauseButton"){
             if(Time.timeScale > 0)
            {
                Time.timeScale = 0;
                gamePaused = true;
                
            } else if (Time.timeScale == 0){
                Time.timeScale = 1;
                gamePaused = false;
            }
          } else if(gameObject.tag == "Resume"){
          			Time.timeScale = 1;
          			gamePaused = false;
          }
     }

	// Update is called once per frame
	void Update () {
	
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
