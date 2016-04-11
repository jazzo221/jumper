using UnityEngine;
using System.Collections;

public class grounded : MonoBehaviour {
	private movement mov;


	// Use this for initialization
	void Start () {
		
		mov = gameObject.GetComponentInParent<movement> ();
	}

	void OnTriggerEnter2D(Collider2D colider){
		mov.ground = true;
	} 

	void OnTriggerExit2D(Collider2D colider){
		mov.ground = false;
	} 
}
