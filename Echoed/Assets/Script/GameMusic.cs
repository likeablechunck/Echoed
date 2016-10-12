using UnityEngine;
using System.Collections;

public class GameMusic : MonoBehaviour
{
    public string state;
    bool playedOnce;
    public AudioSource audioSource1;
    public AudioClip tutorialPartAClip;
    public AudioClip tutorialPartBClip;
    public AudioClip gamePlayClip;
    public bool stopPlaying;

    // Use this for initialization
    void Start ()
    {
        state = "normal";
        playedOnce = false;
        stopPlaying = false;

    }
	
	// Update is called once per frame
	void Update ()
    {
        if (state == "tutorialPartA")
        {
            tutorialPartA();
        }
        if (state == "tutorialPartB")
        {
            tutorialPartB();
        }
        if (state == "gamePlay")
        {
            gamePlay();
        }

    }
    public void changeState(string stateName)
    {
        state = stateName;
        print("current Music state is :" + stateName);
    }
    public void tutorialPartA()
    {
        if (audioSource1.clip == tutorialPartAClip)
        {
            if (!audioSource1.isPlaying)
            {
                audioSource1.Play();

            }
        }
        else
        {
            audioSource1.clip = tutorialPartAClip;
        }
    }
    public void tutorialPartB()
    {
        if (audioSource1.clip == tutorialPartBClip && !stopPlaying)
        {
            if (!audioSource1.isPlaying)
            {
                audioSource1.Play();

            }
        }
        if(audioSource1.clip != tutorialPartBClip)
        {
            audioSource1.clip = tutorialPartBClip;
        }
        if(stopPlaying)
        {
            audioSource1.Stop();
        }
    }
    public void gamePlay()
    {
        if (audioSource1.clip == gamePlayClip && !stopPlaying)
        {
            if (!audioSource1.isPlaying)
            {
                audioSource1.Play();

            }
        }
        if (audioSource1.clip != gamePlayClip)
        {
            audioSource1.clip = gamePlayClip;
        }
        if (stopPlaying)
        {
            audioSource1.Stop();
        }
    }
}
