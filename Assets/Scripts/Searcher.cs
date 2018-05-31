using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Searcher : MonoBehaviour {

	public GameObject sObject;
	public string location;
	public Text locationText;

	public IEnumerator Start()
	{
		LocationService ls = new LocationService ();
		ls.Start ();
		// First, check if user has location service enabled
		if (!Input.location.isEnabledByUser)
			yield break;

		// Start service before querying location
		Input.location.Start();

		// Wait until service initializes
		int maxWait = 20;
		while (Input.location.status == LocationServiceStatus.Initializing && maxWait > 0)
		{
			yield return new WaitForSeconds(1);
			maxWait--;
		}

		// Service didn't initialize in 20 seconds
		if (maxWait < 1)
		{
			print("Timed out");
			yield break;
		}

		// Connection has failed
		if (Input.location.status == LocationServiceStatus.Failed)
		{
			print("Unable to determine device location");
			yield break;
		}
		else
		{
			// Access granted and location value could be retrieved
			string ltxt = "Location: " + Input.location.lastData.latitude + " " + Input.location.lastData.longitude + " " + Input.location.lastData.altitude + " " + Input.location.lastData.horizontalAccuracy + " " + Input.location.lastData.timestamp;
			print(ltxt);
			locationText.text = ltxt;
		}

		// Stop service if there is no need to query location updates continuously
		Input.location.Stop();
	}

	// Update is called once per frame
	void Update () {

	}

	public void OnClick()
	{
		location = "Location: " + Input.location.lastData.latitude + " " + Input.location.lastData.longitude + " " + Input.location.lastData.altitude + " " + Input.location.lastData.horizontalAccuracy + " " + Input.location.lastData.timestamp;
		locationText.text = location;
	}

	public void OnGUI()
	{
		GUI.Label(new Rect(10,10,100,20), location);
	}
}
