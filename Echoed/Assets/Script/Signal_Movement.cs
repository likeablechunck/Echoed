using UnityEngine;
using System.Collections;

public class Signal_Movement : MonoBehaviour
{
    public Vector2 startgPosition;
    public Vector2 endPosition;
    float signalSpeed;

	// Use this for initialization
	void Start ()
    {
        startgPosition = new Vector2(11, -4.2f);
        endPosition = new Vector2(-11, -4.2f);
        transform.position = startgPosition;
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        Vector2 currenPosition = transform.position;
        if (currenPosition.x >= startgPosition.x && currenPosition.y >= startgPosition.y && 
            transform.position.x <= endPosition.x && transform.position.y <= endPosition.y)
        {


        }
        else
        {
            Destroy(this.gameObject);
        }
	
	}
}
