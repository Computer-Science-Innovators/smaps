using System.Collections; 
using System.Collections.Generic; 
using UnityEngine; 
using UnityEngine.UI;

public class LinkClick : MonoBehaviour {

    public void LinkFunc()
    {
         Application.OpenURL ("http://www.google.com");
    }
}
