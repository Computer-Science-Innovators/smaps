using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Searcher : MonoBehaviour {

	public GameObject sObject;

	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	public void OnClick()
	{
		try
		{
			GetComponent<Control>().search(sObject.GetComponent<InputField>().text);

		}
		catch
		{
			Debug.LogError("Text is wrong");
		}

	}
}
