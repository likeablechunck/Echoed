using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Visual_Cues_Instantiation : MonoBehaviour {


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
        timeElapsedInSecs = 0;
        timeElapsed = 0;
        firstArrayIndex = 0;
        secondArrayIndex = 0;

        //this will be the order of Obstacles that will appear on screen
        //empty empty fill fill arrow
        //This will repeat for 30secs
        for (int i = 1; i < 34; i++)
        {
            whatToInstantiateFirst.Add("Signals/Empty_Circle2");
            whatToInstantiateFirst.Add("Signals/Empty_Circle2");
            whatToInstantiateFirst.Add("Signals/Empty_Circle2");
            whatToInstantiateFirst.Add("Signals/Filled_Circle2");
            whatToInstantiateFirst.Add("Signals/Filled_Circle2");
            whatToInstantiateFirst.Add("Signals/Up_Arrow2");
            whatToInstantiateFirst.Add("Signals/Empty_Circle2");
            whatToInstantiateFirst.Add("Signals/Filled_Circle2");
            whatToInstantiateFirst.Add("Signals/Filled_Circle2");
            whatToInstantiateFirst.Add("Signals/Down_Arrow2");
            whatToInstantiateFirst.Add("Signals/Empty_Circle2");
            whatToInstantiateFirst.Add("Signals/Filled_Circle2");
            whatToInstantiateFirst.Add("Signals/Filled_Circle2");
            whatToInstantiateFirst.Add("Signals/Up_Arrow2");
            whatToInstantiateFirst.Add("Signals/Empty_Circle2");
            whatToInstantiateFirst.Add("Signals/Filled_Circle2");
            whatToInstantiateFirst.Add("Signals/Filled_Circle2");
            whatToInstantiateFirst.Add("Signals/Up_Arrow2");
            whatToInstantiateFirst.Add("Signals/Empty_Circle2");
            whatToInstantiateFirst.Add("Signals/Filled_Circle2");
            whatToInstantiateFirst.Add("Signals/Filled_Circle2");
            whatToInstantiateFirst.Add("Signals/Down_Arrow2");
            whatToInstantiateFirst.Add("Signals/Empty_Circle2");
            whatToInstantiateFirst.Add("Signals/Filled_Circle2");
            whatToInstantiateFirst.Add("Signals/Filled_Circle2");
            whatToInstantiateFirst.Add("Signals/Down_Arrow2");
            whatToInstantiateFirst.Add("Signals/Empty_Circle2");
            whatToInstantiateFirst.Add("Signals/Filled_Circle2");
            whatToInstantiateFirst.Add("Signals/Filled_Circle2");
            whatToInstantiateFirst.Add("Signals/Down_Arrow2");
            whatToInstantiateFirst.Add("Signals/Empty_Circle2");
            whatToInstantiateFirst.Add("Signals/Filled_Circle2");
            whatToInstantiateFirst.Add("Signals/Filled_Circle2");
            whatToInstantiateFirst.Add("Signals/Up_Arrow2");
            whatToInstantiateFirst.Add("Signals/Empty_Circle2");
            whatToInstantiateFirst.Add("Signals/Filled_Circle2");
            whatToInstantiateFirst.Add("Signals/Filled_Circle2");
            whatToInstantiateFirst.Add("Signals/Up_Arrow2");
            whatToInstantiateFirst.Add("Signals/Empty_Circle2");
            whatToInstantiateFirst.Add("Signals/Filled_Circle2");
            whatToInstantiateFirst.Add("Signals/Filled_Circle2");
            whatToInstantiateFirst.Add("Signals/Down_Arrow2");

        }
        for (int j = 1; j < 16; j++)
        {
            whatToInstantiateSecond.Add("Signals/Empty_Circle2");
            whatToInstantiateSecond.Add("Signals/Filled_Circle2");
            whatToInstantiateSecond.Add("Signals/Filled_Circle2");
            whatToInstantiateSecond.Add("Signals/Down_Arrow2");
            whatToInstantiateSecond.Add("Signals/Empty_Circle2");
            whatToInstantiateSecond.Add("Signals/Filled_Circle2");
            whatToInstantiateSecond.Add("Signals/Filled_Circle2");
            whatToInstantiateSecond.Add("Signals/Up_Arrow2");
            whatToInstantiateSecond.Add("Signals/Empty_Circle2");
            whatToInstantiateSecond.Add("Signals/Filled_Circle2");
            whatToInstantiateSecond.Add("Signals/Filled_Circle2");
            whatToInstantiateSecond.Add("Signals/Up_Arrow2");
            whatToInstantiateSecond.Add("Signals/Empty_Circle2");
            whatToInstantiateSecond.Add("Signals/Filled_Circle2");
            whatToInstantiateSecond.Add("Signals/Filled_Circle2");
            whatToInstantiateSecond.Add("Signals/Down_Arrow2");
        }
        //print("array has " + whatToInstantiateFirst.Count + "elements");
        //print("elements : " + whatToInstantiateFirst);
    }


    // Update is called once per frame
    void Update()
    {

        timeElapsed = timeElapsed + Time.deltaTime;
        print("Time elapsed is " + timeElapsed);

        ////Here we will tell every N seconds or milliseconds, items need to be instantiated

        //if ((timeElapsed - timeElapsedInSecs) > 1.0f)
        //{
        //    //print("Time elapsed is: " + timeElapsed);
        //    string objectToInstantiateName = (string)whatToInstantiateFirst[timeElapsedInSecs];
        //    Object testObj = Resources.Load(objectToInstantiateName);
        //    if (testObj != null)
        //    {
        //        tempObj = (Instantiate(testObj,
        //            new Vector2(11, -4.2f),
        //            Quaternion.identity)) as GameObject;
        //    }
        //    else
        //    {
        //        print("you wanted me to instantiate an object named " + objectToInstantiateName + " but i did not find it");
        //    }
        //    timeElapsedInSecs++;
        //    //print("Time in secs is " + timeElapsedInSecs);
        //    //print("Time elapsed is " + timeElapsed);
        //    print("signal that was just instantiated was :" + tempObj);
        //}
        GameObject player = GameObject.Find("Player");

        if (player != null)
        {
            if (timeElapsed >= 0 && timeElapsed < 34)
            {
                if ((timeElapsed - timeElapsedInSecs) > 1.31f)
                {
                    //print("Time elapsed is: " + timeElapsed);
                    string objectToInstantiateName = (string)whatToInstantiateFirst[firstArrayIndex];
                    //print("the signal I just instantiated was : " + objectToInstantiateName);
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
                    timeElapsedInSecs += 1.31f;
                    firstArrayIndex++;
                    //print("Time in secs is " + timeElapsedInSecs);
                    //print("Time elapsed is " + timeElapsed);
                    print("signal that was just instantiated was :" + tempObj);
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
                            new Vector2(11, -4.2f),
                            Quaternion.identity)) as GameObject;
                    }
                    else
                    {
                        print("you wanted me to instantiate an object named " + objectToInstantiateSecondName + " but i did not find it");
                    }
                    timeElapsedInSecs += 1.07f;
                    secondArrayIndex++;
                    //print("Time in secs is " + timeElapsedInSecs);
                    //print("Time elapsed is " + timeElapsed);
                    print("signal that was just instantiated was :" + tempObj);
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
