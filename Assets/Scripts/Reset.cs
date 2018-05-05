using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Reset : MonoBehaviour {

	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	public void OnClick()
	{
		try
		{
			GetComponent<Control>().reset();

		}
		catch
		{
			Debug.LogError("Text is wrong");
		}

	}
}
