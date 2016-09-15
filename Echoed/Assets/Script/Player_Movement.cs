using UnityEngine;
using System.Collections;

public class Player_Movement : MonoBehaviour
{

	// Use this for initialization
	void Start ()
    {
        //iTween.MoveTo(gameObject, iTween.Hash("path", iTweenPath.GetPath(""), "time", 5));
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        if(Input.GetKey(KeyCode.UpArrow))
        {
            iTween.MoveTo(gameObject, iTween.Hash("path", iTweenPath.GetPath("Up"), "time", 1, "easetype", iTween.EaseType.easeInOutSine));
            //iTween.MoveTo(gameObject, iTween.Hash("path", iTweenPath.GetPath("Up"), "time", 3));

        }
        if(Input.GetKey(KeyCode.DownArrow))
        {
            iTween.MoveTo(gameObject, iTween.Hash("path", iTweenPath.GetPath("Down"), "time", 1, "easetype", iTween.EaseType.easeInOutSine));
        }
	

	}
}
