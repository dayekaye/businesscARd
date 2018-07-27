using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchWebsite : MonoBehaviour {
    
    public void OpenURL()
    {

        //insta
        if (gameObject.name == "InstagramButton") {
            Application.OpenURL("https://www.instagram.com/dayekaye/");
        }

        //fb
        if (gameObject.name == "FacebookButton")
        {
            Application.OpenURL("https://www.facebook.com/daye.kaye10");
        }

        //twitter
        if (gameObject.name == "TwitterButton")
        {
            Application.OpenURL("https://twitter.com/momomDaye");
        }
    }
}
