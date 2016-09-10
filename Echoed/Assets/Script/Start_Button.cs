using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Start_Button : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        this.gameObject.SetActive(false);

    }

    public void onClick()
    {
        SceneManager.LoadScene(1);
    }

}
