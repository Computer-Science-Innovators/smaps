using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveSchedule : MonoBehaviour {

	public InputField fullNameInput;
	public static string fullName;

	public InputField r1Input;
	public static string r1;

	public InputField r2Input;
	public static string r2;

	public InputField r3Input;
	public static string r3;

	public InputField r4Input;
	public static string r4;

	public InputField r5Input;
	public static string r5;

	public InputField r6Input;
	public static string r6;

	public InputField r7Input;
	public static string r7;

	public InputField r8Input;
	public static string r8;

	// Use this for initialization
	void Start () {
		fullNameInput.text = fullName;
		r1Input.text = r1;
		r2Input.text = r2;
		r3Input.text = r3;
		r4Input.text = r4;
		r5Input.text = r5;
		r6Input.text = r6;
		r7Input.text = r7;
		r8Input.text = r8;
	}

	// These methods will be called from somewhere else - in an OnClick method
	public void SaveUsername(string newName) {
		fullName = newName;
	}

	public void SaveRoom1(string newRoom) {
		r1 = newRoom;
	}

	public void SaveRoom2(string newRoom) {
		r2 = newRoom;
	}

	public void SaveRoom3(string newRoom) {
		r3 = newRoom;
	}

	public void SaveRoom4(string newRoom) {
		r4 = newRoom;
	}

	public void SaveRoom5(string newRoom) {
		r5 = newRoom;
	}

	public void SaveRoom6(string newRoom) {
		r6 = newRoom;
	}

	public void SaveRoom7(string newRoom) {
		r7 = newRoom;
	}

	public void SaveRoom8(string newRoom) {
		r8 = newRoom;
	}

}
