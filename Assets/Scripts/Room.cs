using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room : MonoBehaviour {

	public string[] neighbors;
	public float[] distances;
	public bool visited;
	public float tDistance;

	public bool corridor;
	void Start () {
		distances = new float[neighbors.Length];
		for (int i=0; i<neighbors.Length; i++) {
			distances [i] = Vector3.Distance (transform.position, GameObject.Find (neighbors [i] + "").transform.position);
		}

	}


	// Update is called once per frame
	void Update () {
		

	}

	void OnDrawGizmosSelected(){
		for (int i = 0; i < neighbors.Length; i++) {
			Gizmos.color = Color.blue;
			Gizmos.DrawLine (transform.position,GameObject.Find(neighbors[i]).transform.position);
		}
	}
}
