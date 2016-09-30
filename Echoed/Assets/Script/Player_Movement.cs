using UnityEngine;
using System.Collections;

public class Player_Movement : MonoBehaviour
{

    public Vector2 playerInitialPosition;
	// Use this for initialization
	void Start ()
    {
        transform.position = playerInitialPosition; 
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        PlayerMusic PM = Camera.main.GetComponent<PlayerMusic>();
        PM.changeState("flying");
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            iTween.MoveTo(gameObject, iTween.Hash("path", iTweenPath.GetPath("Up"), "time", 2.6f, "easetype", iTween.EaseType.linear));
           
        }
        if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            iTween.MoveTo(gameObject, iTween.Hash("path", iTweenPath.GetPath("Down"), "time", 2.6f, "easetype", iTween.EaseType.linear));
        }
	

	}

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Obstacle")
        {
            //It needs to display the lose scene and returns to the tutorial
            print("I collided with : " + col.name);
            PlayerMusic pm = Camera.main.GetComponent<PlayerMusic>();
            pm.changeState("smashed");
            //stop the flying music & switch to Smash music
            Destroy(this.gameObject, 1.5f);

        }
    }
}
