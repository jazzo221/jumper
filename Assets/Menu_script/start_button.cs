using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class start_button : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Start_Button(){
		SceneManager.LoadScene ("game");
		//Application.LoadLevel("game");
	
	}

	public void GUI_Button(){
		SceneManager.LoadScene ("GUI");
		//Application.LoadLevel("game");

	}

}
