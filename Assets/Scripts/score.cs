using UnityEngine;
using System.Collections;

public class score : MonoBehaviour {

	public int  score_value = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void Awake() {
		DontDestroyOnLoad(this.gameObject);
	}
}
