using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Score:MonoBehaviour{
	public GameObject gameOverParent, mainMenuParent, Score1DoubDig, Score1TopL, Score1Top, Score1TopR, Score1Mid, Score1BottomL, Score1Bottom, Score1BottomR, Score2DoubDig, Score2TopL, Score2Top, Score2TopR, Score2Mid, Score2BottomL, Score2Bottom, Score2BottomR;
	public bool gameOverClose = false;

	// starts visual score at 0
	void Start(){
		Score1DoubDig = GameObject.Find("Score1DoubDig");
		Score1TopL = GameObject.Find("Score1TopL");
		Score1Top = GameObject.Find("Score1Top");
		Score1TopR = GameObject.Find("Score1TopR");
		Score1Mid = GameObject.Find("Score1Mid");
		Score1BottomL = GameObject.Find("Score1BottomL");
		Score1Bottom = GameObject.Find("Score1Bottom");
		Score1BottomR = GameObject.Find("Score1BottomR");
		Score1DoubDig.GetComponent<Renderer>().enabled = false;
		Score1TopL.GetComponent<Renderer>().enabled = true;
		Score1Top.GetComponent<Renderer>().enabled = true;
		Score1TopR.GetComponent<Renderer>().enabled = true;
		Score1Mid.GetComponent<Renderer>().enabled = false;
		Score1BottomL.GetComponent<Renderer>().enabled = true;
		Score1Bottom.GetComponent<Renderer>().enabled = true;
		Score1BottomR.GetComponent<Renderer>().enabled = true;

		Score2DoubDig = GameObject.Find("Score2DoubDig");
		Score2TopL = GameObject.Find("Score2TopL");
		Score2Top = GameObject.Find("Score2Top");
		Score2TopR = GameObject.Find("Score2TopR");
		Score2Mid = GameObject.Find("Score2Mid");
		Score2BottomL = GameObject.Find("Score2BottomL");
		Score2Bottom = GameObject.Find("Score2Bottom");
		Score2BottomR = GameObject.Find("Score2BottomR");
		Score2DoubDig.GetComponent<Renderer>().enabled = false;
		Score2TopL.GetComponent<Renderer>().enabled = true;
		Score2Top.GetComponent<Renderer>().enabled = true;
		Score2TopR.GetComponent<Renderer>().enabled = true;
		Score2Mid.GetComponent<Renderer>().enabled = false;
		Score2BottomL.GetComponent<Renderer>().enabled = true;
		Score2Bottom.GetComponent<Renderer>().enabled = true;
		Score2BottomR.GetComponent<Renderer>().enabled = true;

		// Hides game over screen at start
		gameOverParent = GameObject.Find("GameOverParent");
		foreach(Transform child in gameOverParent.transform){
			child.gameObject.SetActive(false);
		}
	}
	
	//closes game over menu if its up
	void OnMouseDown(){
		gameOverParent = GameObject.Find("GameOverMenu");
		if(gameObject.tag == "GameOverParent"){
			gameOverClose = true;
		}
	}

	// updates score
	void Update(){
		//sets visual score variables to correspond with unity objects
		Score1DoubDig = GameObject.Find("Score1DoubDig");
		Score1TopL = GameObject.Find("Score1TopL");
		Score1Top = GameObject.Find("Score1Top");
		Score1TopR = GameObject.Find("Score1TopR");
		Score1Mid = GameObject.Find("Score1Mid");
		Score1BottomL = GameObject.Find("Score1BottomL");
		Score1Bottom = GameObject.Find("Score1Bottom");
		Score1BottomR = GameObject.Find("Score1BottomR");
		
		Score2DoubDig = GameObject.Find("Score2DoubDig");
		Score2TopL = GameObject.Find("Score2TopL");
		Score2Top = GameObject.Find("Score2Top");
		Score2TopR = GameObject.Find("Score2TopR");
		Score2Mid = GameObject.Find("Score2Mid");
		Score2BottomL = GameObject.Find("Score2BottomL");
		Score2Bottom = GameObject.Find("Score2Bottom");
		Score2BottomR = GameObject.Find("Score2BottomR");

		//allows access to player1/2score from Ball.cs
		GameObject ball = GameObject.Find("Ball");
		Ball score = ball.GetComponent<Ball>();

		//displays visual score based on player1score increments in Ball.cs
		switch(score.player1Score){
			case 1:
				Score1DoubDig.GetComponent<Renderer>().enabled = false;
				Score1TopL.GetComponent<Renderer>().enabled = false;
				Score1Top.GetComponent<Renderer>().enabled = false;
				Score1TopR.GetComponent<Renderer>().enabled = true;
				Score1Mid.GetComponent<Renderer>().enabled = false;
				Score1BottomL.GetComponent<Renderer>().enabled = false;
				Score1Bottom.GetComponent<Renderer>().enabled = false;
				Score1BottomR.GetComponent<Renderer>().enabled = true;
			break;
			case 2:
				Score1DoubDig.GetComponent<Renderer>().enabled = false;
				Score1TopL.GetComponent<Renderer>().enabled = false;
				Score1Top.GetComponent<Renderer>().enabled = true;
				Score1TopR.GetComponent<Renderer>().enabled = true;
				Score1Mid.GetComponent<Renderer>().enabled = true;
				Score1BottomL.GetComponent<Renderer>().enabled = true;
				Score1Bottom.GetComponent<Renderer>().enabled = true;
				Score1BottomR.GetComponent<Renderer>().enabled = false;
			break;
			case 3:
				Score1DoubDig.GetComponent<Renderer>().enabled = false;
				Score1TopL.GetComponent<Renderer>().enabled = false;
				Score1Top.GetComponent<Renderer>().enabled = true;
				Score1TopR.GetComponent<Renderer>().enabled = true;
				Score1Mid.GetComponent<Renderer>().enabled = true;
				Score1BottomL.GetComponent<Renderer>().enabled = false;
				Score1Bottom.GetComponent<Renderer>().enabled = true;
				Score1BottomR.GetComponent<Renderer>().enabled = true;
			break;
			case 4:
				Score1DoubDig.GetComponent<Renderer>().enabled = false;
				Score1TopL.GetComponent<Renderer>().enabled = true;
				Score1Top.GetComponent<Renderer>().enabled = false;
				Score1TopR.GetComponent<Renderer>().enabled = true;
				Score1Mid.GetComponent<Renderer>().enabled = true;
				Score1BottomL.GetComponent<Renderer>().enabled = false;
				Score1Bottom.GetComponent<Renderer>().enabled = false;
				Score1BottomR.GetComponent<Renderer>().enabled = true;
			break;
			case 5:
				Score1DoubDig.GetComponent<Renderer>().enabled = false;
				Score1TopL.GetComponent<Renderer>().enabled = true;
				Score1Top.GetComponent<Renderer>().enabled = true;
				Score1TopR.GetComponent<Renderer>().enabled = false;
				Score1Mid.GetComponent<Renderer>().enabled = true;
				Score1BottomL.GetComponent<Renderer>().enabled = false;
				Score1Bottom.GetComponent<Renderer>().enabled = true;
				Score1BottomR.GetComponent<Renderer>().enabled = true;
			break;
			case 6:
				Score1DoubDig.GetComponent<Renderer>().enabled = false;
				Score1TopL.GetComponent<Renderer>().enabled = true;
				Score1Top.GetComponent<Renderer>().enabled = true;
				Score1TopR.GetComponent<Renderer>().enabled = false;
				Score1Mid.GetComponent<Renderer>().enabled = true;
				Score1BottomL.GetComponent<Renderer>().enabled = true;
				Score1Bottom.GetComponent<Renderer>().enabled = true;
				Score1BottomR.GetComponent<Renderer>().enabled = true;
			break;
			case 7:
				Score1DoubDig.GetComponent<Renderer>().enabled = false;
				Score1TopL.GetComponent<Renderer>().enabled = false;
				Score1Top.GetComponent<Renderer>().enabled = true;
				Score1TopR.GetComponent<Renderer>().enabled = true;
				Score1Mid.GetComponent<Renderer>().enabled = false;
				Score1BottomL.GetComponent<Renderer>().enabled = false;
				Score1Bottom.GetComponent<Renderer>().enabled = false;
				Score1BottomR.GetComponent<Renderer>().enabled = true;
			break;
			case 8:
				Score1DoubDig.GetComponent<Renderer>().enabled = false;
				Score1TopL.GetComponent<Renderer>().enabled = true;
				Score1Top.GetComponent<Renderer>().enabled = true;
				Score1TopR.GetComponent<Renderer>().enabled = true;
				Score1Mid.GetComponent<Renderer>().enabled = true;
				Score1BottomL.GetComponent<Renderer>().enabled = true;
				Score1Bottom.GetComponent<Renderer>().enabled = true;
				Score1BottomR.GetComponent<Renderer>().enabled = true;
			break;
			case 9:
				Score1DoubDig.GetComponent<Renderer>().enabled = false;
				Score1TopL.GetComponent<Renderer>().enabled = true;
				Score1Top.GetComponent<Renderer>().enabled = true;
				Score1TopR.GetComponent<Renderer>().enabled = true;
				Score1Mid.GetComponent<Renderer>().enabled = true;
				Score1BottomL.GetComponent<Renderer>().enabled = false;
				Score1Bottom.GetComponent<Renderer>().enabled = false;
				Score1BottomR.GetComponent<Renderer>().enabled = true;
			break;
			case 10:
				Score1DoubDig.GetComponent<Renderer>().enabled = true;
				Score1TopL.GetComponent<Renderer>().enabled = true;
				Score1Top.GetComponent<Renderer>().enabled = true;
				Score1TopR.GetComponent<Renderer>().enabled = true;
				Score1Mid.GetComponent<Renderer>().enabled = false;
				Score1BottomL.GetComponent<Renderer>().enabled = true;
				Score1Bottom.GetComponent<Renderer>().enabled = true;
				Score1BottomR.GetComponent<Renderer>().enabled = true;
			break;
			case 11:
				Score1DoubDig.GetComponent<Renderer>().enabled = true;
				Score1TopL.GetComponent<Renderer>().enabled = false;
				Score1Top.GetComponent<Renderer>().enabled = false;
				Score1TopR.GetComponent<Renderer>().enabled = true;
				Score1Mid.GetComponent<Renderer>().enabled = false;
				Score1BottomL.GetComponent<Renderer>().enabled = false;
				Score1Bottom.GetComponent<Renderer>().enabled = false;
				Score1BottomR.GetComponent<Renderer>().enabled = true;

				//ends game, displays game over screen with winner
				Time.timeScale = 0;
				gameOverParent = GameObject.Find("GameOverParent");
			  foreach(Transform child in gameOverParent.transform){
					if(child.gameObject.name == "Black" || child.gameObject.name == "GameOver" || child.gameObject.name == "PlayerOneWins"){
						child.gameObject.SetActive(true);
					} else{
						child.gameObject.SetActive(false);
					}
				}

				//resets game back to main menu when game over screen is clicked
				if(gameOverClose){
	      	SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	      }
			break;
			default:
				//displays 0
				Score1DoubDig.GetComponent<Renderer>().enabled = false;
				Score1TopL.GetComponent<Renderer>().enabled = true;
				Score1Top.GetComponent<Renderer>().enabled = true;
				Score1TopR.GetComponent<Renderer>().enabled = true;
				Score1Mid.GetComponent<Renderer>().enabled = false;
				Score1BottomL.GetComponent<Renderer>().enabled = true;
				Score1Bottom.GetComponent<Renderer>().enabled = true;
				Score1BottomR.GetComponent<Renderer>().enabled = true;
			break;
		}

		//displays visual score based on player2score increments in Ball.cs
		switch(score.player2Score){
			case 1:
				Score2DoubDig.GetComponent<Renderer>().enabled = false;
				Score2TopL.GetComponent<Renderer>().enabled = false;
				Score2Top.GetComponent<Renderer>().enabled = false;
				Score2TopR.GetComponent<Renderer>().enabled = true;
				Score2Mid.GetComponent<Renderer>().enabled = false;
				Score2BottomL.GetComponent<Renderer>().enabled = false;
				Score2Bottom.GetComponent<Renderer>().enabled = false;
				Score2BottomR.GetComponent<Renderer>().enabled = true;
			break;
			case 2:
				Score2DoubDig.GetComponent<Renderer>().enabled = false;
				Score2TopL.GetComponent<Renderer>().enabled = false;
				Score2Top.GetComponent<Renderer>().enabled = true;
				Score2TopR.GetComponent<Renderer>().enabled = true;
				Score2Mid.GetComponent<Renderer>().enabled = true;
				Score2BottomL.GetComponent<Renderer>().enabled = true;
				Score2Bottom.GetComponent<Renderer>().enabled = true;
				Score2BottomR.GetComponent<Renderer>().enabled = false;
			break;
			case 3:
				Score2DoubDig.GetComponent<Renderer>().enabled = false;
				Score2TopL.GetComponent<Renderer>().enabled = false;
				Score2Top.GetComponent<Renderer>().enabled = true;
				Score2TopR.GetComponent<Renderer>().enabled = true;
				Score2Mid.GetComponent<Renderer>().enabled = true;
				Score2BottomL.GetComponent<Renderer>().enabled = false;
				Score2Bottom.GetComponent<Renderer>().enabled = true;
				Score2BottomR.GetComponent<Renderer>().enabled = true;
			break;
			case 4:
				Score2DoubDig.GetComponent<Renderer>().enabled = false;
				Score2TopL.GetComponent<Renderer>().enabled = true;
				Score2Top.GetComponent<Renderer>().enabled = false;
				Score2TopR.GetComponent<Renderer>().enabled = true;
				Score2Mid.GetComponent<Renderer>().enabled = true;
				Score2BottomL.GetComponent<Renderer>().enabled = false;
				Score2Bottom.GetComponent<Renderer>().enabled = false;
				Score2BottomR.GetComponent<Renderer>().enabled = true;
			break;
			case 5:
				Score2DoubDig.GetComponent<Renderer>().enabled = false;
				Score2TopL.GetComponent<Renderer>().enabled = true;
				Score2Top.GetComponent<Renderer>().enabled = true;
				Score2TopR.GetComponent<Renderer>().enabled = false;
				Score2Mid.GetComponent<Renderer>().enabled = true;
				Score2BottomL.GetComponent<Renderer>().enabled = false;
				Score2Bottom.GetComponent<Renderer>().enabled = true;
				Score2BottomR.GetComponent<Renderer>().enabled = true;
			break;
			case 6:
				Score2DoubDig.GetComponent<Renderer>().enabled = false;
				Score2TopL.GetComponent<Renderer>().enabled = true;
				Score2Top.GetComponent<Renderer>().enabled = true;
				Score2TopR.GetComponent<Renderer>().enabled = false;
				Score2Mid.GetComponent<Renderer>().enabled = true;
				Score2BottomL.GetComponent<Renderer>().enabled = true;
				Score2Bottom.GetComponent<Renderer>().enabled = true;
				Score2BottomR.GetComponent<Renderer>().enabled = true;
			break;
			case 7:
				Score2DoubDig.GetComponent<Renderer>().enabled = false;
				Score2TopL.GetComponent<Renderer>().enabled = false;
				Score2Top.GetComponent<Renderer>().enabled = true;
				Score2TopR.GetComponent<Renderer>().enabled = true;
				Score2Mid.GetComponent<Renderer>().enabled = false;
				Score2BottomL.GetComponent<Renderer>().enabled = false;
				Score2Bottom.GetComponent<Renderer>().enabled = false;
				Score2BottomR.GetComponent<Renderer>().enabled = true;
			break;
			case 8:
				Score2DoubDig.GetComponent<Renderer>().enabled = false;
				Score2TopL.GetComponent<Renderer>().enabled = true;
				Score2Top.GetComponent<Renderer>().enabled = true;
				Score2TopR.GetComponent<Renderer>().enabled = true;
				Score2Mid.GetComponent<Renderer>().enabled = true;
				Score2BottomL.GetComponent<Renderer>().enabled = true;
				Score2Bottom.GetComponent<Renderer>().enabled = true;
				Score2BottomR.GetComponent<Renderer>().enabled = true;
			break;
			case 9:
				Score2DoubDig.GetComponent<Renderer>().enabled = false;
				Score2TopL.GetComponent<Renderer>().enabled = true;
				Score2Top.GetComponent<Renderer>().enabled = true;
				Score2TopR.GetComponent<Renderer>().enabled = true;
				Score2Mid.GetComponent<Renderer>().enabled = true;
				Score2BottomL.GetComponent<Renderer>().enabled = false;
				Score2Bottom.GetComponent<Renderer>().enabled = false;
				Score2BottomR.GetComponent<Renderer>().enabled = true;
			break;
			case 10:
				Score2DoubDig.GetComponent<Renderer>().enabled = true;
				Score2TopL.GetComponent<Renderer>().enabled = true;
				Score2Top.GetComponent<Renderer>().enabled = true;
				Score2TopR.GetComponent<Renderer>().enabled = true;
				Score2Mid.GetComponent<Renderer>().enabled = false;
				Score2BottomL.GetComponent<Renderer>().enabled = true;
				Score2Bottom.GetComponent<Renderer>().enabled = true;
				Score2BottomR.GetComponent<Renderer>().enabled = true;
			break;
			case 11:
				Score2DoubDig.GetComponent<Renderer>().enabled = true;
				Score2TopL.GetComponent<Renderer>().enabled = false;
				Score2Top.GetComponent<Renderer>().enabled = false;
				Score2TopR.GetComponent<Renderer>().enabled = true;
				Score2Mid.GetComponent<Renderer>().enabled = false;
				Score2BottomL.GetComponent<Renderer>().enabled = false;
				Score2Bottom.GetComponent<Renderer>().enabled = false;
				Score2BottomR.GetComponent<Renderer>().enabled = true;

				//ends game, displays game over screen with winner
				Time.timeScale = 0;
				gameOverParent = GameObject.Find("GameOverParent");
			  foreach(Transform child in gameOverParent.transform){
					if (child.gameObject.name == "Black" || child.gameObject.name == "GameOver" || child.gameObject.name == "ComputerWins"){
						child.gameObject.SetActive(true);
					} else{
						child.gameObject.SetActive(false);
					}
				}

				//resets game back to main menu when game over screen is clicked
				if (gameOverClose){
	      	SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	      }
			break;
			default:
				//displays 0
				Score2DoubDig.GetComponent<Renderer>().enabled = false;
				Score2TopL.GetComponent<Renderer>().enabled = true;
				Score2Top.GetComponent<Renderer>().enabled = true;
				Score2TopR.GetComponent<Renderer>().enabled = true;
				Score2Mid.GetComponent<Renderer>().enabled = false;
				Score2BottomL.GetComponent<Renderer>().enabled = true;
				Score2Bottom.GetComponent<Renderer>().enabled = true;
				Score2BottomR.GetComponent<Renderer>().enabled = true;
			break;
		}
	}
}
