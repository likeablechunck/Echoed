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
     
    }
	
	// Update is called once per frame
	void Update ()
    {       
        timeElapsed = timeElapsed + Time.deltaTime;
        print("Time elapsed is " + timeElapsed);

        GameObject player = GameObject.Find("Player");
        if (player != null)
        {
            Music music = Camera.main.GetComponent<Music>();
            if (timeElapsed >= tutorialStart && timeElapsed < tutorialMiddle)
            {
                
                music.changeState("tutorialPartA");
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
        }     
    }
}
