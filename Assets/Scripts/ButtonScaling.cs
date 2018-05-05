using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class ButtonScaling : MonoBehaviour {

	public float factor=1;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		float newTarget = Mathf.Min (Screen.width / factor, Screen.height / factor);
		transform.localScale=(new Vector3(newTarget,newTarget,newTarget));
	}
}
