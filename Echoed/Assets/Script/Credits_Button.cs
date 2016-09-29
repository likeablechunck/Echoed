using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Credits_Button : MonoBehaviour
{


    public void onClick()
    {
        Music music = Camera.main.GetComponent<Music>();
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
        SceneManager.LoadScene("Credits");
    }
}
