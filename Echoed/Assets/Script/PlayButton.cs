﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{

	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}
    public void onClick()
    {
        BackgroundMusic music = Camera.main.GetComponent<BackgroundMusic>();
        music.changeState("clicked");
        changeScene();
    }
    void changeScene()
    {
        StartCoroutine("Delay");
    }
    IEnumerator Delay()
    {
        yield return new WaitForSeconds(.1f);
        SceneManager.LoadScene("Main");
    }
}
