using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class UI:MonoBehaviour{
	public GameObject pauseParent, mainMenuParent;
	public bool gamePaused;

	// Use this for initialization
	void Start(){
    //displays main menu at game start
    mainMenuParent = GameObject.Find("MainMenuParent");
    foreach (Transform child in mainMenuParent.transform){
      child.gameObject.SetActive(true);
    }
    Time.timeScale = 0;
  }

	void OnMouseDown(){
    //made object a collider first and tagged it
    if(gameObject.tag == "PauseButton"){
      //toggles pause button
      if(Time.timeScale > 0){
        Time.timeScale = 0;
        gamePaused = true;
      } else if (Time.timeScale == 0){
        Time.timeScale = 1;
        gamePaused = false;
      }
    //resumes game from pause menu
    } else if(gameObject.tag == "Resume"){
      Time.timeScale = 1;
      gamePaused = false;
    //starts game
    } else if(gameObject.tag == "PlayButton"){
      Time.timeScale = 1;
    //resets game upon game over or quit to main menu is clicked from pause
    } else if(gameObject.tag == "GameOverParent"){
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
  }

	// Update is called once per frame
	void Update(){
    //hides main menu when game begins
    mainMenuParent = GameObject.Find("MainMenuParent");
    if(Time.timeScale == 1){
      foreach (Transform child in mainMenuParent.transform){
        child.gameObject.SetActive(false);
      }
    }

    // displays/hides pause menu
    pauseParent = GameObject.Find("PauseParent");
    foreach (Transform child in pauseParent.transform){
      if(Time.timeScale > 0){
        child.gameObject.SetActive(false);
      } else if(Time.timeScale == 0 && gamePaused){
        child.gameObject.SetActive(true);
      }
    }
	}
}
