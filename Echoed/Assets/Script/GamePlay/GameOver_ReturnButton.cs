using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class GameOver_ReturnButton : MonoBehaviour {

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
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
        yield return new WaitForSeconds(.25f);
        SceneManager.LoadScene("Main");
    }
}
