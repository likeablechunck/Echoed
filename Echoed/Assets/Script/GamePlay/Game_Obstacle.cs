using UnityEngine;
using System.Collections;

public class Game_Obstacle : MonoBehaviour
{
    public ArrayList whatToInstantiateFirst = new ArrayList();
    public float timeElapsedInSecs;
    GameObject tempObj;
    public float timeElapsed;
    int firstArrayIndex;


    // Use this for initialization
    void Start ()
    {
        firstArrayIndex = 0;
        timeElapsedInSecs = 0;
        timeElapsed = 0;

        whatToInstantiateFirst.Add("Obstacles/Obstacle_None");
        whatToInstantiateFirst.Add("Obstacles/Obstacle_None");
        whatToInstantiateFirst.Add("Obstacles/Obstacle_None");
        whatToInstantiateFirst.Add("Obstacles/Obstacle_Top");
        whatToInstantiateFirst.Add("Obstacles/Obstacle_None");
        whatToInstantiateFirst.Add("Obstacles/Obstacle_None");
        whatToInstantiateFirst.Add("Obstacles/Obstacle_None");
        whatToInstantiateFirst.Add("Obstacles/Obstacle_Top");
        whatToInstantiateFirst.Add("Obstacles/Obstacle_None");
        whatToInstantiateFirst.Add("Obstacles/Obstacle_None");
        whatToInstantiateFirst.Add("Obstacles/Obstacle_None");
        whatToInstantiateFirst.Add("Obstacles/Obstacle_Top");
        whatToInstantiateFirst.Add("Obstacles/Obstacle_None");
        whatToInstantiateFirst.Add("Obstacles/Obstacle_None");
        whatToInstantiateFirst.Add("Obstacles/Obstacle_None");
        whatToInstantiateFirst.Add("Obstacles/Obstacle_Down");
        whatToInstantiateFirst.Add("Obstacles/Obstacle_None");
        whatToInstantiateFirst.Add("Obstacles/Obstacle_None");
        whatToInstantiateFirst.Add("Obstacles/Obstacle_None");
        whatToInstantiateFirst.Add("Obstacles/Obstacle_Top");
        whatToInstantiateFirst.Add("Obstacles/Obstacle_None");
        whatToInstantiateFirst.Add("Obstacles/Obstacle_None");
        whatToInstantiateFirst.Add("Obstacles/Obstacle_None");
        whatToInstantiateFirst.Add("Obstacles/Obstacle_Down");
        whatToInstantiateFirst.Add("Obstacles/Obstacle_None");
        whatToInstantiateFirst.Add("Obstacles/Obstacle_None");
        whatToInstantiateFirst.Add("Obstacles/Obstacle_None");
        whatToInstantiateFirst.Add("Obstacles/Obstacle_Down");
        whatToInstantiateFirst.Add("Obstacles/Obstacle_None");
        whatToInstantiateFirst.Add("Obstacles/Obstacle_None");
        whatToInstantiateFirst.Add("Obstacles/Obstacle_None");
        whatToInstantiateFirst.Add("Obstacles/Obstacle_Top");
        whatToInstantiateFirst.Add("Obstacles/Obstacle_None");
        whatToInstantiateFirst.Add("Obstacles/Obstacle_None");
        whatToInstantiateFirst.Add("Obstacles/Obstacle_None");
        whatToInstantiateFirst.Add("Obstacles/Obstacle_Down");
        whatToInstantiateFirst.Add("Obstacles/Obstacle_None");
        whatToInstantiateFirst.Add("Obstacles/Obstacle_None");
        whatToInstantiateFirst.Add("Obstacles/Obstacle_None");
        whatToInstantiateFirst.Add("Obstacles/Obstacle_Top");
        whatToInstantiateFirst.Add("Obstacles/Obstacle_None");
        whatToInstantiateFirst.Add("Obstacles/Obstacle_None");
        whatToInstantiateFirst.Add("Obstacles/Obstacle_None");
        whatToInstantiateFirst.Add("Obstacles/Obstacle_Down");
        whatToInstantiateFirst.Add("Obstacles/Obstacle_None");
        whatToInstantiateFirst.Add("Obstacles/Obstacle_None");
        whatToInstantiateFirst.Add("Obstacles/Obstacle_None");
        whatToInstantiateFirst.Add("Obstacles/Obstacle_Top");
        whatToInstantiateFirst.Add("Obstacles/Obstacle_None");
        whatToInstantiateFirst.Add("Obstacles/Obstacle_None");
        whatToInstantiateFirst.Add("Obstacles/Obstacle_None");
        whatToInstantiateFirst.Add("Obstacles/Obstacle_Top");
        whatToInstantiateFirst.Add("Obstacles/Obstacle_None");
        whatToInstantiateFirst.Add("Obstacles/Obstacle_None");
        whatToInstantiateFirst.Add("Obstacles/Obstacle_None");
        whatToInstantiateFirst.Add("Obstacles/Obstacle_Down");
        whatToInstantiateFirst.Add("Obstacles/Obstacle_None");
        whatToInstantiateFirst.Add("Obstacles/Obstacle_None");
        whatToInstantiateFirst.Add("Obstacles/Obstacle_None");
        whatToInstantiateFirst.Add("Obstacles/Obstacle_Down");
        whatToInstantiateFirst.Add("Obstacles/Obstacle_None");
        whatToInstantiateFirst.Add("Obstacles/Obstacle_None");
        whatToInstantiateFirst.Add("Obstacles/Obstacle_None");
        whatToInstantiateFirst.Add("Obstacles/Obstacle_Top");
        whatToInstantiateFirst.Add("Obstacles/Obstacle_None");
        whatToInstantiateFirst.Add("Obstacles/Obstacle_None");
        whatToInstantiateFirst.Add("Obstacles/Obstacle_None");
        whatToInstantiateFirst.Add("Obstacles/Obstacle_Down");
        whatToInstantiateFirst.Add("Obstacles/Obstacle_None");
        whatToInstantiateFirst.Add("Obstacles/Obstacle_None");
        whatToInstantiateFirst.Add("Obstacles/Obstacle_None");
        whatToInstantiateFirst.Add("Obstacles/Obstacle_Down");
        whatToInstantiateFirst.Add("Obstacles/Obstacle_None");
        whatToInstantiateFirst.Add("Obstacles/Obstacle_None");
        whatToInstantiateFirst.Add("Obstacles/Obstacle_None");
        whatToInstantiateFirst.Add("Obstacles/Obstacle_Down");
        whatToInstantiateFirst.Add("Obstacles/Obstacle_None");
        whatToInstantiateFirst.Add("Obstacles/Obstacle_None");
        whatToInstantiateFirst.Add("Obstacles/Obstacle_None");
        whatToInstantiateFirst.Add("Obstacles/Obstacle_Down");
        whatToInstantiateFirst.Add("Obstacles/End_Game_Trigger");
        whatToInstantiateFirst.Add("Obstacles/Obstacle_None");
        whatToInstantiateFirst.Add("Obstacles/Obstacle_None");

    }
	
	// Update is called once per frame
	void Update ()
    {
        timeElapsed = timeElapsed + Time.deltaTime;
        print("Time elapsed: " + timeElapsed);
        GameObject player = GameObject.Find("Player");

        if (player != null)
        {
            if ((timeElapsed - timeElapsedInSecs) > .85f)
            {
                string objectToInstantiateName = (string)whatToInstantiateFirst[firstArrayIndex];
                Object testObj = Resources.Load(objectToInstantiateName);
                if (testObj != null)
                {
                    tempObj = (Instantiate(testObj,
                        new Vector2(10.8f, 1.26f),
                        Quaternion.identity)) as GameObject;
                }
                else
                {
                    //print("you wanted me to instantiate an object named " + objectToInstantiateName + " but i did not find it");
                }
                timeElapsedInSecs += .85f;
                firstArrayIndex++;
                print("Obstacle that was just instantiated in GamePlay was :" + tempObj);
            }
        }

    }
}
