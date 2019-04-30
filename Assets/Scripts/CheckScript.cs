using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckScript : MonoBehaviour
{
    public string station;
    public GameObject SampleAudio;
    public GameObject SampleVideo;
    bool isPlaying;
    public GameObject CurrentAudio;
    public GameObject CurrentVideo;

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

        if (station == "Film")
        {
            if (!isPlaying)
            {
                CurrentVideo = Instantiate(SampleVideo);
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

        if (station == "Film")
        {
            CurrentVideo.GetComponent<Destroy>().DestroyObject();
            isPlaying = false;
        }
    }
}
