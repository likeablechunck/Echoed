using UnityEngine;
using System.Collections;

public class Music : MonoBehaviour
{
    public string state;
    bool playedOnce;
    //AudioSource1 will take care of main game's musics
    public AudioSource audioSource1;
    //AudioSOurce2 takes care of Cave sound
    public AudioSource audioSource2;
    //AudioSource3 will take care of Bat's sounds
    public AudioSource audioSource3;
    public AudioClip buttonClip;
    public AudioClip caveClip;
    public AudioClip tutorialPartAClip;
    public AudioClip tutorialPartBClip;
    //public AudioClip gamePlayClip;
    public AudioClip flyingClip;
    public AudioClip smashingClip;

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
        if(state == "tutorialPartA")
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
        if ( state == "flying")
        {
            flying();
        }
        if ( state == "smashed")
        {
            smashed();
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

        //Bat's Movements sounds
    public void flying()
    {
        if (audioSource3.clip == flyingClip)
        {
            if (!audioSource3.isPlaying)
            {
                audioSource3.Play();

            }
        }
        else
        {
            audioSource3.clip = flyingClip;
        }
    }
    public void smashed()
    {
        if (audioSource3.clip == smashingClip)
        {
            if (audioSource3.isPlaying)
            {
                playedOnce = true;
            }
            else
            {
                if (!playedOnce)
                {
                    audioSource3.Play();
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
            audioSource3.clip = smashingClip;
        }

    }

    //Clicking Sound

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
            audioSource2.clip = buttonClip ;
        }
    }    
}
