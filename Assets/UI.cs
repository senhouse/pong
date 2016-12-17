using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour {
	public GameObject pauseParent, mainMenuParent, pauseMenu, paused, options, mainMenu;
	public bool gamePaused;
	public bool onePlayerGame;

	// Use this for initialization
	void Start () {
		pauseMenu = GameObject.Find("PauseMenu");
		paused = GameObject.Find("Paused");
		//resume = GameObject.Find("Resume");
		options = GameObject.Find("Options");

        mainMenuParent = GameObject.Find("MainMenuParent");
        foreach (Transform child in mainMenuParent.transform)
                {
                    child.gameObject.SetActive(true);
                }
        Time.timeScale = 0;
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
          } else if(gameObject.tag == "OnePlayerButton"){
                onePlayerGame = true;
                Time.timeScale = 1;
          } else if(gameObject.tag == "TwoPlayersButton"){
                onePlayerGame = false;
                Time.timeScale = 1;
          }
          
     }

	// Update is called once per frame
	void Update () {

        mainMenuParent = GameObject.Find("MainMenuParent");
        if (Time.timeScale == 1){
            foreach (Transform child in mainMenuParent.transform){
                child.gameObject.SetActive(false);
            }
        }
        pauseParent = GameObject.Find("PauseParent");
        foreach (Transform child in pauseParent.transform){
            if (Time.timeScale > 0) {
                child.gameObject.SetActive(false);
            } else if (Time.timeScale == 0 && gamePaused){
                child.gameObject.SetActive(true);
            }
        }
	}
}
