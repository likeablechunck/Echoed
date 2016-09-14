using UnityEngine;
using System.Collections;

public class BG_Scrolling : MonoBehaviour {

    public float speed;
    public float x_boarder;
    public float x_initial_position;

    // Use this for initialization
    void Start()
    {
        x_boarder = -4f;
        x_initial_position = 0f;
        this.transform.position = new Vector3(x_initial_position, 0, 0);

    }

    // Update is called once per frame
    void Update()
    {
        GameObject player = GameObject.Find("Player");
        if (player != null)
        {
            this.transform.Translate(speed * -Time.deltaTime, 0, 0);
            print("Background is at: " + transform.position);
            // If past a certain point on X
            if (this.transform.position.x <= x_boarder)
            {
                print("Background passed the boundries");
                // Jump far to the right
                //distance between the boundry and the initial point(in X)
                this.transform.Translate(-(this.transform.position.x - x_initial_position), 0, 0);
            }
        }
    }

}
