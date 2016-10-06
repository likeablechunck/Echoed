using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Game_Controller : MonoBehaviour
{
    public bool gamePlayPlayed;
    float timeElapsed;

	// Use this for initialization
	void Start ()
    {
        gamePlayPlayed = false;
        timeElapsed = 0;
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        timeElapsed = timeElapsed + Time.deltaTime;
        GameObject player = GameObject.Find("Player");
        GameMusic music = Camera.main.GetComponent<GameMusic>();
        if (player != null)
        {
            if(gamePlayPlayed == false)
            {
                music.changeState("gamePlay");
                gamePlayPlayed = true;
            }   
            if(timeElapsed >=79f)
            {
                SceneManager.LoadScene("Win");
            }       
        }
        else
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
