using UnityEngine;
using System.Collections;

public class PlayerMusic : MonoBehaviour
{
    public string state;
    bool playedOnce;
    //AudioSource3 will take care of Bat's sounds
    public AudioSource audioSource3;
    public AudioClip flyingClip;
    public AudioClip smashingClip;
    //public AudioClip flappingWingsClip;

    // Use this for initialization
    void Start()
    {
        state = "normal";
        playedOnce = false;

    }

    // Update is called once per frame
    void Update ()
    {
        if (state == "flying")
        {
            flying();
        }
        if (state == "smashed")
        {
            smashed();
        }
        //if(state == "flappingWings")
        //{
        //    flappingWings();
        //}

    }
    public void changeState(string stateName)
    {
        state = stateName;
        print("current Music state for the player is :" + stateName);
    }
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
    //public void flappingWings()
    //{
    //    if (audioSource3.clip == flappingWingsClip)
    //    {
    //        if (audioSource3.isPlaying)
    //        {
    //            playedOnce = true;
    //        }
    //        else
    //        {
    //            if (!playedOnce)
    //            {
    //                audioSource3.Play();
    //            }
    //            else
    //            {
    //                playedOnce = false;
    //                //changeState("normal");

    //            }
    //        }
    //    }
    //    else
    //    {
    //        audioSource3.clip = flappingWingsClip;
    //    }

    //}
}
