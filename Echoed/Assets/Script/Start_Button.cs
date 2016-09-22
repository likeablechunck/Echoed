using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Start_Button : MonoBehaviour
{

    public void onClick()
    {
        SceneManager.LoadScene("Tutorial_Page");
    }

}
