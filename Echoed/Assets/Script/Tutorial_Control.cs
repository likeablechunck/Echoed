using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Tutorial_Control : MonoBehaviour
{  
   
    public float timeElapsed;
    public float tutorialStart;
    public float tutorialMiddle;
    public float tutorialEnd;
    public bool changedToPartB;
   
    
	// Use this for initialization
	void Start ()
    {
       
        timeElapsed = 0;
        changedToPartB = false;
        StartCoroutine(PlayPartA());
        StartCoroutine(fading());
    }
	
	// Update is called once per frame
	void Update ()
    {       
        timeElapsed = timeElapsed + Time.deltaTime;
        print("Time elapsed is " + timeElapsed);

        GameObject player = GameObject.Find("Player");
        if (player != null)
        {
            //PlayerMusic PM = Camera.main.GetComponent<PlayerMusic>();
            //PM.changeState("flying");
            GameMusic music = Camera.main.GetComponent<GameMusic>();
            
            if( timeElapsed >= tutorialMiddle && timeElapsed <= tutorialEnd)
            {
                if (changedToPartB == false)
                {
                    music.changeState("tutorialPartB");
                    changedToPartB = true;
                }
                
            }
        }
        else
        {
            //When player dies!!
            //go back to the beggining of the tutorial & play the crashing
            SceneManager.LoadScene("Loose_Tutorial");
        }
        if (timeElapsed >= 70)
        {
            GameMusic music = Camera.main.GetComponent<GameMusic>();
            music.audioSource1.Stop();
        }

    }
    public void MusicChanger()
    {
        GameMusic music = Camera.main.GetComponent<GameMusic>();
        music.changeState("tutorialPartA");

    }
    IEnumerator fading()
    {
        float fadeTime = Camera.main.GetComponent<Fading>().BeginFade(-1);
        yield return new WaitForSeconds(fadeTime);

    }
   
    IEnumerator PlayPartA()   {
        Debug.Log("10 second wait is about to start");
        yield return StartCoroutine(Delay(10.0f));
        Debug.Log("10 second wait is over");
        GameMusic music = Camera.main.GetComponent<GameMusic>();
        music.changeState("tutorialPartA");
    }

    IEnumerator Delay(float seconds)
    {
        yield return new WaitForSeconds(seconds);
    }
}
