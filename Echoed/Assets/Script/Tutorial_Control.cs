using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Tutorial_Control : MonoBehaviour
{  
    public float timeElapsedInSecs;
    public float timeElapsed;
    public float tutorialStart;
    public float tutorialMiddle;
    public float tutorialEnd;
    
	// Use this for initialization
	void Start ()
    {
        timeElapsedInSecs = 0;
        timeElapsed = 0;
        StartCoroutine(PlayPartA());
    }
	
	// Update is called once per frame
	void Update ()
    {       
        timeElapsed = timeElapsed + Time.deltaTime;
        //print("Time elapsed is " + timeElapsed);

        GameObject player = GameObject.Find("Player");
        if (player != null)
        {
            GameMusic music = Camera.main.GetComponent<GameMusic>();
            if (timeElapsed >= tutorialStart && timeElapsed < tutorialMiddle)
            {
                //music.changeState("tutorialPartA");
                //print("I am about to call DELAY function");
                //StartCoroutine("Delay");
                
            }
            if( timeElapsed >= tutorialMiddle && timeElapsed <= tutorialEnd)
            {
                music.changeState("tutorialPartB");

            }
        }
        else
        {
            //When player dies!!
            //go back to the beggining of the tutorial & play the crashing
            SceneManager.LoadScene("Loose_Tutorial");
        }     
    }
    public void MusicChanger()
    {
        GameMusic music = Camera.main.GetComponent<GameMusic>();
        music.changeState("tutorialPartA");

    }
    IEnumerator PlayPartA()
    {
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
