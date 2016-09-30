using UnityEngine;
using System.Collections;

public class BackgroundMusic : MonoBehaviour
{
    public string state;
    bool playedOnce;
    public AudioSource audioSource2;
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
        if (state == "clicked")
        {
            clicked();
        }

    }
    public void changeState(string stateName)
    {
        state = stateName;
        print("current Music state is :" + stateName);
    }

    public void normal()
    {
        if (audioSource2.clip == caveClip)
        {
            if (!audioSource2.isPlaying)
            {
                audioSource2.Play();

            }
        }
        else
        {
            audioSource2.clip = caveClip;
        }
    }
    public void clicked()
    {
        if (audioSource2.clip == buttonClip)
        {
            if (audioSource2.isPlaying)
            {
                playedOnce = true;
            }
            else
            {
                if (!playedOnce)
                {
                    audioSource2.Play();
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
            audioSource2.clip = buttonClip;
        }
    }
}
