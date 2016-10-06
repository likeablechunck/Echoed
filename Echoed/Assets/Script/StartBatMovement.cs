using UnityEngine;
using System.Collections;

public class StartBatMovement : MonoBehaviour
{
    public Vector2 initialPosition;
   // public Vector3 speed;
    float timeElapsed;

	// Use this for initialization
	void Start ()
    {
        iTween.MoveTo(gameObject, iTween.Hash("path", iTweenPath.GetPath("Up_Down"), "time", 3.5f, "easetype", iTween.EaseType.linear));
        //transform.position = initialPosition;
        timeElapsed = 0;
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        timeElapsed += Time.deltaTime;

        if (timeElapsed >0)
        {
            //iTween.MoveTo(gameObject, iTween.Hash("path", iTweenPath.GetPath("Up_Down"), "time", 3.5f, "easetype", iTween.EaseType.linear));
        } 
        
    }
}
