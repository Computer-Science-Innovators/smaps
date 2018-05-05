using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockingCamera : MonoBehaviour {
    Camera cam;

    // Use this for initialization
    void Start () {
        cam =  GetComponent<Camera>();
        Vector3 vc = new Vector3(-Screen.width + 1, Screen.height / 2 - 1,0);
        GameObject[] array = GameObject.FindGameObjectsWithTag("button");
        array[0].transform.position = vc;
        array[1].transform.position = vc;
        array[2].transform.position = vc;


    }

    // Update is called once per frame
    void Update () {
		
	}
}
