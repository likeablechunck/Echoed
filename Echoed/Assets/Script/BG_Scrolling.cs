using UnityEngine;
using System.Collections;

public class BG_Scrolling : MonoBehaviour
{
    public float x_boarder;
    public Vector3 initial_position;
    public float timeStart;
    public float betweenTwoTutorial;
    public float endOfTime;


    // Use this for initialization
    void Start()
    {
        initial_position = new Vector3(84,0,50);
        this.transform.position = initial_position;
    }

    // Update is called once per frame
    void Update()
    {
        GameObject player = GameObject.Find("Player");
        Tutorial_Control TC = Camera.main.GetComponent<Tutorial_Control>();
        //print("Time elapsed: + " + TC.timeElapsed);

        if (player != null)
        {
            if (TC.timeElapsed > timeStart && TC.timeElapsed <= betweenTwoTutorial)
            {
                screen_mover(2.93f);
            }
            if (TC.timeElapsed > betweenTwoTutorial && TC.timeElapsed < endOfTime)
            {
                screen_mover(3.2f);
            }

        }
        else
        {
            //What to do when player dies!!!
        }
    }
    public void screen_mover(float speed)
    {
        print("Speed is : " + speed);
        this.transform.Translate(speed * -Time.deltaTime, 0, 0);
        if (this.transform.position.x <= x_boarder)
        {
            this.transform.Translate(-(this.transform.position.x - initial_position.x), 0, 0);
        }

    }
}

