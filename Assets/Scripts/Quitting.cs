using UnityEngine;
using System.Collections;

public class Quitting : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey("escape"))
            Application.Quit();

    }

    public void ReallyQuit()
    {
        Application.Quit();

    }
}