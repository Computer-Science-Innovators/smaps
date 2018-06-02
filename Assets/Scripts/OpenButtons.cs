using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenButtons : MonoBehaviour {

	public GameObject roomDiv;
	public GameObject pathDiv;
	public GameObject scheduleDiv;

	// Use this for initialization
	void Start ()
	{

	}

	// Update is called once per frame
	void Update ()
	{

	}

	public void OnClick()
	{
		// Hide/Reveal roomDiv
		if(roomDiv.GetComponent<Animator> ().GetBool("open")!=true)
			roomDiv.GetComponent<Animator> ().SetBool ("open", true);
		else
			roomDiv.GetComponent<Animator> ().SetBool ("open", false);

		// Hide/Reveal pathDiv
		if(pathDiv.GetComponent<Animator> ().GetBool("open")!=true)
			pathDiv.GetComponent<Animator> ().SetBool ("open", true);
		else
			pathDiv.GetComponent<Animator> ().SetBool ("open", false);

		// Hide/Reveal scheduleDiv
		if(scheduleDiv.GetComponent<Animator> ().GetBool("open")!=true)
			scheduleDiv.GetComponent<Animator> ().SetBool ("open", true);
		else
			scheduleDiv.GetComponent<Animator> ().SetBool ("open", false);
	}
}
