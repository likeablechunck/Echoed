using UnityEngine;
using System.Collections;

public class GameMusic : MonoBehaviour
{
    public string state;
    bool playedOnce;
    public AudioSource audioSource1;
    public AudioClip tutorialPartAClip;
    public AudioClip tutorialPartBClip;
    //public AudioClip gamePlayClip;

    // Use this for initialization
    void Start ()
    {
        state = "normal";
        playedOnce = false;

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
        //if( state == "gamePlay")
        //{
        //    gamePlay();
        //}

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
        if (audioSource1.clip == tutorialPartBClip)
        {
            if (!audioSource1.isPlaying)
            {
                audioSource1.Play();

            }
        }
        else
        {
            audioSource1.clip = tutorialPartBClip;
        }
    }
    //public void gamePlay()
    //{
    //    if (audioSource1.clip == gamePlayClip)
    //    {
    //        if (!audioSource1.isPlaying)
    //        {
    //            audioSource1.Play();

    //        }
    //    }
    //    else
    //    {
    //        audioSource1.clip = gamePlayClip;
    //    }
    //}
}
