using UnityEngine;
using System.Collections;

public class Statemanager : MonoBehaviour {

	private GameObject gameOverText;  
	private GameObject winText;  
	private GameObject player; 
	
	public enum states{
		MENU,
		PLAY,
		DEAD,
		WIN
	};

	public static states STATE;

	void Awake(){
		STATE = states.MENU;
	}

	// Use this for initialization
	void Start () {
		gameOverText = GameObject.Find ("GameOver");
		winText = GameObject.Find ("Win");
		player = GameObject.Find ("SpaceCraft");
		gameOverText.SetActive (false);
		winText.SetActive (false);





	}


	// Update is called once per frame
	void Update () {
		if(STATE == states.MENU){
			//MENU

			Time.timeScale = 0;


		}else if(STATE == states.PLAY){
			//PLAY		
			Time.timeScale = 1;
		}else if(STATE == states.DEAD){
			//DEAD


			gameOverText.SetActive(true);
			
			if(Input.GetKeyUp(KeyCode.R)){
				reset ();
			}
		}else if(STATE == states.WIN){
			//WIN
			player.SetActive(false);

			winText.SetActive(true);
		
			if(Input.GetKeyUp(KeyCode.R)){
				reset ();
			}
		}

	}


	//Do all the reset here
	public static void reset(){
		GameStatus.reset();
		Application.LoadLevel (0);
	}
}
