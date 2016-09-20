using UnityEngine;
using System.Collections;


public class Credits : MonoBehaviour
{
    public AudioSource audio;
    public AudioClip typingSound;
    bool typedBefore;
    public bool isItReady;
    string myString = "\t-Raquel Flores\n\t-Bryce Cheung\n\t-Henry Kuh\n\t-Faranak Razavi";
    public GameObject button;
    //public GameObject button2;
    bool characterIsNull;
    // Use this for initialization
    void Start()
    {

        StartCoroutine("typeText");
        isItReady = false;
        typedBefore = false;
        characterIsNull = false;

    }


    IEnumerator typeText()
    {
        foreach (char letter in myString.ToCharArray())
        {


            GetComponent<GUIText>().text += letter;
            yield return 0;
            yield return new WaitForSeconds(.04f);
        }

        //after finishing with all the letters in string, set the button to active so player can Return to start menu
        isItReady = true;
        characterIsNull = true;
    }
    void Update()
    {
        if (!typedBefore && !characterIsNull)
        {
            if (audio.clip = typingSound)
            {
                playing();
            }
            else
            {
                audio.clip = typingSound;
            }
        }
        else if (characterIsNull)
        {
            audio.Stop();
        }


        if (isItReady)
        {

            button.SetActive(true);
            //button2.SetActive(true);

        }
    }
    public void playing()
    {
        if (!audio.isPlaying)
        {

            audio.Play();
        }

    }

}

