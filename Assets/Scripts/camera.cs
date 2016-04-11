using UnityEngine;
using System.Collections;

public class camera : MonoBehaviour {
	public GameObject GO;
	public Vector3 offset;

	// Use this for initialization
	void Start () {
		offset = transform.position - GO.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = GO.transform.position + offset;
	}
}
