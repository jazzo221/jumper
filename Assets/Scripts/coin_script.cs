using UnityEngine;
using System.Collections;

public class coin_script : MonoBehaviour {
	

	private score test;

	// Use this for initialization
	void Start () {
		
		test = gameObject.GetComponentInParent<score> ();

	}
	
	// Update is called once per frame
	void Update () {
		//sc;

	}



	void OnTriggerEnter2D(Collider2D colider){
		//destroyed = true;
		//obj.GetComponent<score>().score_value++;
		//obj.s
		test.score_value++;
		Destroy(this.gameObject);

	} 
}
