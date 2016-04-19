using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class score_finish : MonoBehaviour {
	Text sc;
	score score;
	GameObject coins;
	// Use this for initialization
	void Start () {
		sc = GetComponent<Text> ();
		coins = GameObject.Find("coins");
		score  = coins.GetComponent<score>();
		sc.text = "Score: "+ score.score_value;
		DestroyImmediate (coins);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
