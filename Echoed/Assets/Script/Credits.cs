using UnityEngine;
using System.Collections;


public class Credits : MonoBehaviour
{
    public AudioSource audio;
    public AudioClip typingSound;
    bool typedBefore;
    public bool isItReady;
    string myString = " -Raquel Flores\n\tCharacter Modeler\n\n-Faranak Razavi\n\tGame Designer/Developer\n\n-Bryce Cheung\n\tAudio Designer\n\n-Henry Ku\n\tCharacter Modeler";
    public GameObject button1;
    public GameObject button2;
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

            button1.SetActive(true);
            button2.SetActive(true);

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

