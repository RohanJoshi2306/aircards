using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenURL : MonoBehaviour
{
    void Start()
    {
        
    }
    void Update()
    {
        
    }

    public void instagram()
    {
        Application.OpenURL("https://www.instagram.com/vitpunerobotics/");
    }

    public void facebook()
    {
        Application.OpenURL("https://www.facebook.com/trfvit/");
    }

    public void linkedin()
    {
        Application.OpenURL("https://www.linkedin.com/company/the-robotics-forum/");
    }

    public void website()
    {
        Application.OpenURL("https://www.vitpunerobotics.com/");
    }
}
