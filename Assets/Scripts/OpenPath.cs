using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class OpenPath : MonoBehaviour {

	public GameObject pathDiv;
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	public void OnClick()
	{
		if(pathDiv.GetComponent<Animator> ().GetBool("open")!=true)
		pathDiv.GetComponent<Animator> ().SetBool ("open", true);
		else
			pathDiv.GetComponent<Animator> ().SetBool ("open", false);

	}
}
