using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckScript : MonoBehaviour
{
    public string station;

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(station + " activated");
    }

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log(station + " deactivated");
    }
}
