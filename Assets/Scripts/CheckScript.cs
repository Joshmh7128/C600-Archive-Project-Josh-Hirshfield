using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckScript : MonoBehaviour
{
    public string station;
    public GameObject SampleAudio;
    bool isPlaying;
    public GameObject CurrentAudio;

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(station + " activated");

        if (station == "Audio")
        {
            if (!isPlaying)
            {
                CurrentAudio = Instantiate(SampleAudio);
                isPlaying = true;
            }
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log(station + " deactivated");
        if (station == "Audio")
        {
            CurrentAudio.GetComponent<Destroy>().DestroyObject();
            isPlaying = false;
        }
    }
}
