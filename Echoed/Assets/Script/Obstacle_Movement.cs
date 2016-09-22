using UnityEngine;
using System.Collections;

public class Obstacle_Movement : MonoBehaviour {

    public Vector2 startgPosition;
    public Vector2 endPosition;
    float Obstaclespeed;
    public float timeStart;
    public float betweenTwoTutorial;
    public float endOfTime;

    // Use this for initialization
    void Start()
    {
        transform.position = startgPosition;

    }

    // Update is called once per frame
    void Update()
    {
        GameObject player = GameObject.Find("Player");
        Tutorial_Control TC = Camera.main.GetComponent<Tutorial_Control>();

        if (GameObject.Find("Player") != null)
        {
            if (transform.position.x <= startgPosition.x &&
            transform.position.x >= endPosition.x)
            {
                if (TC.timeElapsedInSecs > timeStart && TC.timeElapsedInSecs <= betweenTwoTutorial)
                {
                    signal_mover(2.93f);
                }
                if (TC.timeElapsedInSecs > betweenTwoTutorial && TC.timeElapsedInSecs < endOfTime)
                {
                    signal_mover(3.2f);
                }

            }
            else
            {
                Destroy(this.gameObject);
            }
        }
        else
        {
            //What to do when player dies!!!
        }

    }
    public void signal_mover(float speed)
    {
        print("Speed is : " + speed);
        this.transform.Translate(speed * -Time.deltaTime, 0, 0);

    }
}
