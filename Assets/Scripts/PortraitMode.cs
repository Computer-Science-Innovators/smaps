using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortraitMode : MonoBehaviour
{

    // Use this for initialization
    public void Start()
    {
        Screen.orientation = ScreenOrientation.Portrait;
    }

    // Update is called once per frame

    void Update()
    {

    }

    //change screen orientation 
    public void OnClick()
    {
        Screen.orientation = ScreenOrientation.LandscapeLeft;
 
    }
}