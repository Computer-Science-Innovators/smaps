using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenButtons : MonoBehaviour {

	public GameObject menuDiv;
	public GameObject resetDiv;
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
		// Hide/Reveal menuDiv
		if(menuDiv.GetComponent<Animator> ().GetBool("open")!=true)
			menuDiv.GetComponent<Animator> ().SetBool ("open", true);
		else
			menuDiv.GetComponent<Animator> ().SetBool ("open", false);

		// Hide/Reveal resetDiv
		if(resetDiv.GetComponent<Animator> ().GetBool("open")!=true)
			resetDiv.GetComponent<Animator> ().SetBool ("open", true);
		else
			resetDiv.GetComponent<Animator> ().SetBool ("open", false);

		// Hide/Reveal scheduleDiv
		if(scheduleDiv.GetComponent<Animator> ().GetBool("open")!=true)
			scheduleDiv.GetComponent<Animator> ().SetBool ("open", true);
		else
			scheduleDiv.GetComponent<Animator> ().SetBool ("open", false);
	}
}
