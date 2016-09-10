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

    // Update is called once per frame
    void Update()
    {
    }
    public void onClick()
    {
        SceneManager.LoadScene(0);
    }
}
