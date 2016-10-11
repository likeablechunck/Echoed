using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Obstacle_Instantiation : MonoBehaviour
{
    public ArrayList whatToInstantiateFirst = new ArrayList();
    public ArrayList whatToInstantiateSecond = new ArrayList();
    public float timeElapsedInSecs;
    GameObject tempObj;
    public float timeElapsed;
    int firstArrayIndex;
    int secondArrayIndex;

    // Use this for initialization
    void Start()
    {
        firstArrayIndex = 0;
        secondArrayIndex = 0;
        timeElapsedInSecs = 0;
        timeElapsed = 0;

        //this will be the order of Obstacles that will appear on screen
        //First part of tutorial
        whatToInstantiateFirst.Add("Obstacles/Obstacle_None");
        whatToInstantiateFirst.Add("Obstacles/Obstacle_None");
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
        whatToInstantiateFirst.Add("Obstacles/Obstacle_Top");

        //second part of tutorial
        whatToInstantiateSecond.Add("Obstacles/Obstacle_None");
        whatToInstantiateSecond.Add("Obstacles/Obstacle_None");
        whatToInstantiateSecond.Add("Obstacles/Obstacle_Top");
        whatToInstantiateSecond.Add("Obstacles/Obstacle_None");
        whatToInstantiateSecond.Add("Obstacles/Obstacle_None");
        whatToInstantiateSecond.Add("Obstacles/Obstacle_Down");
        whatToInstantiateSecond.Add("Obstacles/Obstacle_None");
        whatToInstantiateSecond.Add("Obstacles/Obstacle_None");
        whatToInstantiateSecond.Add("Obstacles/Obstacle_None");
        whatToInstantiateSecond.Add("Obstacles/Obstacle_Down");
        whatToInstantiateSecond.Add("Obstacles/Obstacle_None");
        whatToInstantiateSecond.Add("Obstacles/Obstacle_None");
        whatToInstantiateSecond.Add("Obstacles/Obstacle_Top");
        whatToInstantiateSecond.Add("Obstacles/Obstacle_None");
        whatToInstantiateSecond.Add("Obstacles/Obstacle_None");
        whatToInstantiateSecond.Add("Obstacles/Obstacle_None");
        whatToInstantiateSecond.Add("Obstacles/Obstacle_Top");
        whatToInstantiateSecond.Add("Obstacles/Obstacle_None");
        whatToInstantiateSecond.Add("Obstacles/Obstacle_None");
        whatToInstantiateSecond.Add("Obstacles/Obstacle_Down");
        whatToInstantiateSecond.Add("Obstacles/Obstacle_None");
        whatToInstantiateSecond.Add("Obstacles/Obstacle_None");
        whatToInstantiateSecond.Add("Obstacles/Obstacle_Down");
        whatToInstantiateSecond.Add("Obstacles/Obstacle_None");
        whatToInstantiateSecond.Add("Obstacles/Obstacle_None");
        whatToInstantiateSecond.Add("Obstacles/Obstacle_None");
        whatToInstantiateSecond.Add("Obstacles/Obstacle_None");
        whatToInstantiateSecond.Add("Obstacles/Obstacle_None");
        whatToInstantiateSecond.Add("Obstacles/Obstacle_None");
        whatToInstantiateSecond.Add("Obstacles/End_Trigger");
        whatToInstantiateSecond.Add("Obstacles/Obstacle_None");
        whatToInstantiateSecond.Add("Obstacles/Obstacle_None");
        whatToInstantiateSecond.Add("Obstacles/Obstacle_None");
    }

        // Update is called once per frame
        void Update()
        {

        timeElapsed = timeElapsed + Time.deltaTime;
        //print("Time elapsed: " + timeElapsed);
        GameObject player = GameObject.Find("Player");

        if(player !=null)
        {
            if (timeElapsed >= 0 && timeElapsed < 33.9)
            {
                if ((timeElapsed - timeElapsedInSecs) > 1.304f)
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
                        print("you wanted me to instantiate an object named " + objectToInstantiateName + " but i did not find it");
                    }
                    timeElapsedInSecs += 1.304f;
                    firstArrayIndex++;
                    print("Obstacle that was just instantiated was :" + tempObj);
                }
            }


            if (timeElapsed >= 33.9 && timeElapsed <= 60f)

            {

                if ((timeElapsed - timeElapsedInSecs) > .9f)
                {
                    //print("Time elapsed is: " + timeElapsed);
                    string objectToInstantiateSecondName = (string)whatToInstantiateSecond[secondArrayIndex];
                    Object testObj = Resources.Load(objectToInstantiateSecondName);
                    if (testObj != null)
                    {
                        tempObj = (Instantiate(testObj,
                            new Vector2(10.8f, 1.26f),
                            Quaternion.identity)) as GameObject;
                    }
                    else
                    {
                        print("you wanted me to instantiate an object named " + objectToInstantiateSecondName + " but i did not find it");
                    }
                    timeElapsedInSecs += .9f;
                    secondArrayIndex++;
                    print("Obstacle that was just instantiated was :" + tempObj);
                }
            }


            //if (timeElapsed > 60f)
            //{
            //    SceneManager.LoadScene("Connector");
            //}
        }
        else
        {
            SceneManager.LoadScene("Loose_Tutorial");
        }        
    }
}
