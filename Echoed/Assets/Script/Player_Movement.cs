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
        Music music = Camera.main.GetComponent<Music>();
        music.changeState("flying");
        if (Input.GetKey(KeyCode.UpArrow))
        {
            iTween.MoveTo(gameObject, iTween.Hash("path", iTweenPath.GetPath("Up"), "time", 1.5f, "easetype", iTween.EaseType.easeInOutSine));
           
        }
        if(Input.GetKey(KeyCode.DownArrow))
        {
            iTween.MoveTo(gameObject, iTween.Hash("path", iTweenPath.GetPath("Down"), "time", 1.5f, "easetype", iTween.EaseType.easeInOutSine));
        }
	

	}

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Obstacle")
        {
            //It needs to display the lose scene and returns to the tutorial
            print("I collided with : " + col.name);
            //stop the flying music & switch to Smash music
            //Destroty(this.GameObject, 1);
            
        }
    }
}
