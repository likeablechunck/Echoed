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
        for (int i = 1; i < 34; i++)
        {
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
        }
        for (int j = 1; j < 16; j++)
        {
            whatToInstantiateSecond.Add("Obstacles/Obstacle_None");
            whatToInstantiateSecond.Add("Obstacles/Obstacle_None");
            whatToInstantiateSecond.Add("Obstacles/Obstacle_None");
            whatToInstantiateSecond.Add("Obstacles/Obstacle_Top");
            whatToInstantiateSecond.Add("Obstacles/Obstacle_None");
            whatToInstantiateSecond.Add("Obstacles/Obstacle_None");
            whatToInstantiateSecond.Add("Obstacles/Obstacle_None");
            whatToInstantiateSecond.Add("Obstacles/Obstacle_Down");
            whatToInstantiateSecond.Add("Obstacles/Obstacle_None");
            whatToInstantiateSecond.Add("Obstacles/Obstacle_None");
            whatToInstantiateSecond.Add("Obstacles/Obstacle_None");
            whatToInstantiateSecond.Add("Obstacles/Obstacle_Down");
            whatToInstantiateSecond.Add("Obstacles/Obstacle_None");
            whatToInstantiateSecond.Add("Obstacles/Obstacle_None");
            whatToInstantiateSecond.Add("Obstacles/Obstacle_None");
            whatToInstantiateSecond.Add("Obstacles/Obstacle_Top");
        }
        //print("array has " + whatToInstantiateFirst.Count + "elements");
        //print("elements : " + whatToInstantiateFirst);

    }


    // Update is called once per frame
    void Update()
    {

        timeElapsed = timeElapsed + Time.deltaTime;
        GameObject player = GameObject.Find("Player");

        if(player !=null)
        {
            if (timeElapsed >= 0 && timeElapsed < 34)
            {
                if ((timeElapsed - timeElapsedInSecs) > 1.31f)
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
                    timeElapsedInSecs += 1.31f;
                    firstArrayIndex++;
                    print("Obstacle that was just instantiated was :" + tempObj);
                }
            }
            if (timeElapsed >= 34 && timeElapsed <= 51.14f)
            {
                if ((timeElapsed - timeElapsedInSecs) > 1.07f)
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
                    timeElapsedInSecs += 1.07f;
                    secondArrayIndex++;
                    print("Obstacle that was just instantiated was :" + tempObj);
                }
            }
            if (timeElapsed > 51.14f)
            {
                SceneManager.LoadScene("Main");
            }
        }
        else
        {
            SceneManager.LoadScene("Tutorial_Page");
        }        
    }
}
