using UnityEngine;
using System.Collections;

public class Music : MonoBehaviour
{
    public string state;
    bool playedOnce;
    public AudioSource audioSource;
    public AudioClip buttonClip;
    public AudioClip caveClip;

    // Use this for initialization
    void Start ()
    {
        state = "normal";
        playedOnce = false;

    }
	
	// Update is called once per frame
	void Update ()
    {
        if (state == "normal")
        {
            normal();
        }
        if( state == "clicked")
        {
            clicked();
        }

    }

    public void changeState(string stateName)
    {
        state = stateName;
    }

    public void normal()
    {

        if (audioSource.clip == caveClip)
        {
            if (!audioSource.isPlaying)
            {
                audioSource.Play();

            }

        }
        else
        {
            audioSource.clip = caveClip;
        }

    }

    public void clicked()
    {
        if (audioSource.clip == buttonClip)
        {
            if (audioSource.isPlaying)
            {
                playedOnce = true;
            }
            else
            {
                if (!playedOnce)
                {
                    audioSource.Play();
                }
                else
                {
                    playedOnce = false;
                    //changeState("normal");

                }
            }
        }
        else
        {
            audioSource.clip = buttonClip ;
        }

    }
}
