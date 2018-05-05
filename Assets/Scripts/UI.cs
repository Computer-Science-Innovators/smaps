using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[ExecuteInEditMode]
public class UI : MonoBehaviour {

	public GameObject parent;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (parent.GetComponent<Room> ().corridor == false)
			GetComponent<Text> ().text = parent.name;
		else
			GetComponent<Text> ().enabled = false;
	}
}
