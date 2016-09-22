using UnityEngine;
using System.Collections;

public class Obstacle_Instantiation : MonoBehaviour
{
    public ArrayList whatToInstantiate = new ArrayList();
    public int numberOfLoops;
    public int timeElapsedInSecs;
    GameObject tempObj;
    public float timeElapsed;

    // Use this for initialization
    void Start()
    {
        numberOfLoops = 1;
        timeElapsedInSecs = 0;
        timeElapsed = 0;

        //this will be the order of Obstacles that will appear on screen
        //empty empty fill fill arrow
        //This will repeat for 30secs
        for (int i = 1; i < 42 * numberOfLoops; i = i + 42)
        {
            whatToInstantiate.Add("Obstacles/Obstacle_None");
            whatToInstantiate.Add("Obstacles/Obstacle_None");
            whatToInstantiate.Add("Obstacles/Obstacle_None");
            whatToInstantiate.Add("Obstacles/Obstacle_None");
            whatToInstantiate.Add("Obstacles/Obstacle_None");
            whatToInstantiate.Add("Obstacles/Down_Obstacle");
            whatToInstantiate.Add("Obstacles/Obstacle_None");
            whatToInstantiate.Add("Obstacles/Obstacle_None");
            whatToInstantiate.Add("Obstacles/Obstacle_None");
            whatToInstantiate.Add("Obstacles/Top_Obstacle");
            whatToInstantiate.Add("Obstacles/Obstacle_None");
            whatToInstantiate.Add("Obstacles/Obstacle_None");
            whatToInstantiate.Add("Obstacles/Obstacle_None");
            whatToInstantiate.Add("Obstacles/Down_Obstacle");
            whatToInstantiate.Add("Obstacles/Obstacle_None");
            whatToInstantiate.Add("Obstacles/Obstacle_None");
            whatToInstantiate.Add("Obstacles/Obstacle_None");
            whatToInstantiate.Add("Obstacles/Down_Obstacle");
            whatToInstantiate.Add("Obstacles/Obstacle_None");
            whatToInstantiate.Add("Obstacles/Obstacle_None");
            whatToInstantiate.Add("Obstacles/Obstacle_None");
            whatToInstantiate.Add("Obstacles/Top_Obstacle");
            whatToInstantiate.Add("Obstacles/Obstacle_None");
            whatToInstantiate.Add("Obstacles/Obstacle_None");
            whatToInstantiate.Add("Obstacles/Obstacle_None");
            whatToInstantiate.Add("Obstacles/Top_Obstacle");
            whatToInstantiate.Add("Obstacles/Obstacle_None");
            whatToInstantiate.Add("Obstacles/Obstacle_None");
            whatToInstantiate.Add("Obstacles/Obstacle_None");
            whatToInstantiate.Add("Obstacles/Top_Obstacle");
            whatToInstantiate.Add("Obstacles/Obstacle_None");
            whatToInstantiate.Add("Obstacles/Obstacle_None");
            whatToInstantiate.Add("Obstacles/Obstacle_None");
            whatToInstantiate.Add("Obstacles/Down_Obstacle");
            whatToInstantiate.Add("Obstacles/Obstacle_None");
            whatToInstantiate.Add("Obstacles/Obstacle_None");
            whatToInstantiate.Add("Obstacles/Obstacle_None");
            whatToInstantiate.Add("Obstacles/Down_Obstacle");
            whatToInstantiate.Add("Obstacles/Obstacle_None");
            whatToInstantiate.Add("Obstacles/Obstacle_None");
            whatToInstantiate.Add("Obstacles/Obstacle_None");
            whatToInstantiate.Add("Obstacles/Top_Obstacle");
        }
        print("array has " + whatToInstantiate.Count + "elements");
        print("elements : " + whatToInstantiate);

    }


    // Update is called once per frame
    void Update()
    {

        timeElapsed = timeElapsed + Time.deltaTime;

        if ((timeElapsed - timeElapsedInSecs) > 1.0f)
        {
            //print("Time elapsed is: " + timeElapsed);
            string objectToInstantiateName = (string)whatToInstantiate[timeElapsedInSecs];
            Object testObj = Resources.Load(objectToInstantiateName);
            if (testObj != null)
            {
                tempObj = (Instantiate(testObj,
                    new Vector2(11, -4.2f),
                    Quaternion.identity)) as GameObject;
            }
            else
            {
                print("you wanted me to instantiate an object named " + objectToInstantiateName + " but i did not find it");
            }
            timeElapsedInSecs++;
            print("Time in secs is " + timeElapsedInSecs);
            print("Time elapsed is " + timeElapsed);
            print("signal that was just instantiated was :" + tempObj);
        }
    }
}
