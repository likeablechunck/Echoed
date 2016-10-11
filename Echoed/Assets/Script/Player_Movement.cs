using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Player_Movement : MonoBehaviour
{

    public Vector2 playerInitialPosition;
    public bool flapped;
    public bool smashed;
	// Use this for initialization
	void Start ()
    {
        transform.position = playerInitialPosition;
        flapped = false;
        smashed = false;
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        PlayerMusic PM = Camera.main.GetComponent<PlayerMusic>();
        //print("player's music state is: " + PM.state);
        if (flapped == false || smashed == false)
        {
            PM.changeState("flying");
        }
        if(flapped)
        {
            //print("I flapped");
            PM.changeState("flappingWings");
            
        }
        if(smashed)
        {
            PM.changeState("smashed");
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            flapped = true;
            iTween.MoveTo(gameObject, iTween.Hash("path", iTweenPath.GetPath("Up"), "time", 2.6f, "easetype", iTween.EaseType.linear));
            
        }
        if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            flapped = true;
            iTween.MoveTo(gameObject, iTween.Hash("path", iTweenPath.GetPath("Down"), "time", 2.6f, "easetype", iTween.EaseType.linear));
           
        }
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Obstacle")
        {
            smashed = true;
            //It needs to display the lose scene and returns to the tutorial
            print("I collided with : " + col.name);
            //stop the flying music & switch to Smash music
            transform.Translate(0, 0, 0);
            Destroy(this.gameObject, 0.5f);
        }
        if(col.gameObject.tag == "End_Trigger")
        {
            print("I collided with : " + col.name);
            GameObject endOfTutorial = Instantiate(Resources.Load("Goal_Tutorial", typeof(GameObject))) as GameObject;
        }
        if(col.gameObject.tag == "Scene_Changer")
        {
            print("I collided with : " + col.name);
            SceneManager.LoadScene("Start_Menu");
        }
    }
}
