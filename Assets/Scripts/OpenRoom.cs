using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class OpenRoom : MonoBehaviour {

	public GameObject roomDiv;

	void Start () 
	{

	}

	// Update is called once per frame
	void Update () 
	{

	}

	public void OnClick()
	{
		if(roomDiv.GetComponent<Animator> ().GetBool("open")!=true)
			roomDiv.GetComponent<Animator> ().SetBool ("open", true);
		else
			roomDiv.GetComponent<Animator> ().SetBool ("open", false);

	}
}
