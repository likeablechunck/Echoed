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
        StartCoroutine(GamePlay());
        StartCoroutine(fading());

    }
	
	// Update is called once per frame
	void Update ()
    {
        timeElapsed = timeElapsed + Time.deltaTime;
        GameObject player = GameObject.Find("Player");
        GameMusic music = Camera.main.GetComponent<GameMusic>();
        if (player != null)
        {
            //if(gamePlayPlayed == false)
            //{
            //    music.changeState("gamePlay");
            //    gamePlayPlayed = true;
            //}   
            //if(timeElapsed >=78f)
            //{
            //    SceneManager.LoadScene("Win");
            //}       
        }
        else
        {
            SceneManager.LoadScene("GameOver");
        }
    }
    public void MusicChanger()
    {
        GameMusic music = Camera.main.GetComponent<GameMusic>();
        music.changeState("tutorialPartA");

    }
    IEnumerator GamePlay()
    {
        Debug.Log("10 second wait is about to start");
        yield return StartCoroutine(Delay(10.0f));
        Debug.Log("10 second wait is over");
        GameMusic music = Camera.main.GetComponent<GameMusic>();
        music.changeState("gamePlay");
    }

    IEnumerator Delay(float seconds)
    {
        yield return new WaitForSeconds(seconds);
    }
    IEnumerator fading()
    {
        float fadeTime = Camera.main.GetComponent<Fading>().BeginFade(-1);
        yield return new WaitForSeconds(fadeTime);

    }
}
