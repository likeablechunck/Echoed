using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Start_Button : MonoBehaviour
{

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
        yield return new WaitForSeconds(.30f);
        SceneManager.LoadScene("Tutorial_Page");
    }

}
