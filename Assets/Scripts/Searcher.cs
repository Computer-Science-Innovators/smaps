using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Searcher : MonoBehaviour
{
    public string location = "defaults";
    public Text locationText;
    public GameObject locationMarker;
    public GameObject startingLocation;

    public IEnumerator Start()
    {



        int maxWait = (int)Random.Range(2,10);
        while(maxWait > 0){
            maxWait--;
            locationText.text = "Location : Waiting";
            for (int i = 0; i < maxWait % 3;i++){
                locationText.text += ".";
            }
            new WaitForSeconds(1);
           
        }

        if(!DataKeeper.triggerPassword){

            locationText.text = "Location : Outside of school";

            return null;

        }

        locationText.text = "Location: 700E";

        if(locationMarker == null){
            return null;
        }

        locationMarker.gameObject.transform.position = startingLocation.transform.position;


        return null;
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