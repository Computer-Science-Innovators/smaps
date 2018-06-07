using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Searcher : MonoBehaviour
{

    public GameObject sObject;
    public string location = "defaults";
    public Text locationText;

    public IEnumerator Start()
    {

        print("pre start");

        LocationService ls = new GameObject("LocationService").AddComponent<LocationService>();
        ls.Start();
        // First, check if user has location service enabled
        if (!Input.location.isEnabledByUser)
        {
            print("Location service not enabled");
            yield break;


            // Start service before querying location
            Input.location.Start(10, 500);
            print("ls started");
            // Wait until service initializess
            int maxWait = 20;
            while (Input.location.status == LocationServiceStatus.Initializing && maxWait > 0)
            {
                yield return new WaitForSeconds(1);
                maxWait--;
                print(maxWait);
            }

            // Service didn't initialize in 20 seconds
            if (maxWait < 1)
            {
                print("Timed out");
                yield break;
            }

            print("reached end of wait");

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
                print("got to check1");
                print(Input.location.status);
                locationText.text = ltxt;
            }
        }

        // Update is called once per frame
        void Update()
        {

        }

        public void OnClick()
        {
            location = "Location: " + Input.location.lastData.latitude + " " + Input.location.lastData.longitude + " " + Input.location.lastData.altitude + " " + Input.location.lastData.horizontalAccuracy + " " + Input.location.lastData.timestamp;
            locationText.text = location;
        }

        public void OnGUI()
        {
            GUI.Label(new Rect(10, 10, 100, 20), location);
        }
    }