using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ReferenceClick : MonoBehaviour {

	public GameObject A;
	public GameObject B;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnClick()
	{
		try
		{
			GetComponent<Control>().PathAB(A.GetComponent<InputField>().text, B.GetComponent<InputField>().text,true);

		}
		catch
		{
			Debug.LogError("Text is wrong");
		}

	}
}
