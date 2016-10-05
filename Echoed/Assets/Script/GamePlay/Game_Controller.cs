using UnityEngine;
using System.Collections;

public class Game_Controller : MonoBehaviour
{
    public bool gamePlayPlayed;

	// Use this for initialization
	void Start ()
    {
        gamePlayPlayed = false;
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        GameObject player = GameObject.Find("Player");
        GameMusic music = Camera.main.GetComponent<GameMusic>();
        if (player != null)
        {
            if(gamePlayPlayed == false)
            {
                music.changeState("gamePlay");
                gamePlayPlayed = true;
            }
            
        }
        else
        {

        }

    }
}
