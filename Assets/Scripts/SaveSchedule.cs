using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveSchedule : MonoBehaviour {

	public InputField fullNameInput;
	public static string fullName;

	// Use this for initialization
	void Start () {
		if (fullName != null) {
			fullNameInput.text = fullName;
		}
	}

	public void SaveUsername(string newName) {
		fullName = newName;
	}


}
