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

        print("total number of elements in array is: " + whatToInstantiateFirst.Count);

    }
	
	// Update is called once per frame
	void Update ()
    {
        timeElapsed = timeElapsed + Time.deltaTime;
        GameObject player = GameObject.Find("Player");

        if (player != null)
        {
            //print("Index # that is about to get used is : " + firstArrayIndex);

            //I need to make sure my index that is about to get used is between the the array length
            //Otherwise, it should not do anything if it's out of range.
            if (firstArrayIndex < whatToInstantiateFirst.Count)
            {
                if ((timeElapsed - timeElapsedInSecs) > .91f)
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
                    timeElapsedInSecs += .91f;
                    firstArrayIndex++;
                    print("Obstacle that was just instantiated in GamePlay was :" + tempObj);


                }
            }
            else
            {
                print("you wanted to instantiated" + firstArrayIndex + "th element which I am out of range");
            }
            }
        }

    }

