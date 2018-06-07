using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Scene : MonoBehaviour {

	public Text email;
	public Text password;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	public void OnClick(){
		if ((email.text).EndsWith("wwprsd.org") && (password.text).StartsWith("WWP")) {
			print("Right thing");
			SceneManager.LoadSceneAsync("maps", LoadSceneMode.Single);
			return;
		}
		print("Wrong something");
	}
}
