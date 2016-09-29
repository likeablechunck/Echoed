using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Return_Button_Script : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        this.gameObject.SetActive(false);

    }

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
        SceneManager.LoadScene("Start_Menu");
    }
}
