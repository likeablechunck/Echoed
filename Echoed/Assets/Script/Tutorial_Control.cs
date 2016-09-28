using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Tutorial_Control : MonoBehaviour
{
   
    public float timeElapsedInSecs;
    GameObject tempObj;
    public float timeElapsed;
    int firstArrayIndex;
    int secondArrayIndex;

	// Use this for initialization
	void Start ()
    {
        timeElapsedInSecs = 0;
        timeElapsed = 0;
     
    }

	
	// Update is called once per frame
	void Update ()
    {
        
        timeElapsed = timeElapsed + Time.deltaTime;
        print("Time elapsed is " + timeElapsed);

        //    ////Here we will tell every N seconds or milliseconds, items need to be instantiated

        //    //if ((timeElapsed - timeElapsedInSecs) > 1.0f)
        //    //{
        //    //    //print("Time elapsed is: " + timeElapsed);
        //    //    string objectToInstantiateName = (string)whatToInstantiateFirst[timeElapsedInSecs];
        //    //    Object testObj = Resources.Load(objectToInstantiateName);
        //    //    if (testObj != null)
        //    //    {
        //    //        tempObj = (Instantiate(testObj,
        //    //            new Vector2(11, -4.2f),
        //    //            Quaternion.identity)) as GameObject;
        //    //    }
        //    //    else
        //    //    {
        //    //        print("you wanted me to instantiate an object named " + objectToInstantiateName + " but i did not find it");
        //    //    }
        //    //    timeElapsedInSecs++;
        //    //    //print("Time in secs is " + timeElapsedInSecs);
        //    //    //print("Time elapsed is " + timeElapsed);
        //    //    print("signal that was just instantiated was :" + tempObj);
        //    //}
        //    GameObject player = GameObject.Find("Player");

        //    if(player != null)
        //    {
        //        if (timeElapsed >= 0 && timeElapsed < 34)
        //        {
        //            if ((timeElapsed - timeElapsedInSecs) > 1.31f)
        //            {
        //                //print("Time elapsed is: " + timeElapsed);
        //                string objectToInstantiateName = (string)whatToInstantiateFirst[firstArrayIndex];
        //                //print("the signal I just instantiated was : " + objectToInstantiateName);
        //                Object testObj = Resources.Load(objectToInstantiateName);
        //                if (testObj != null)
        //                {
        //                    tempObj = (Instantiate(testObj,
        //                        new Vector2(11, -4.2f),
        //                        Quaternion.identity)) as GameObject;
        //                }
        //                else
        //                {
        //                    print("you wanted me to instantiate an object named " + objectToInstantiateName + " but i did not find it");
        //                }
        //                timeElapsedInSecs += 1.31f;
        //                firstArrayIndex++;
        //                //print("Time in secs is " + timeElapsedInSecs);
        //                //print("Time elapsed is " + timeElapsed);
        //                print("signal that was just instantiated was :" + tempObj);
        //            }

        //        }
        //        if (timeElapsed >= 34 && timeElapsed <= 51.14f)
        //        {
        //            if ((timeElapsed - timeElapsedInSecs) > 1.07f)
        //            {
        //                //print("Time elapsed is: " + timeElapsed);
        //                string objectToInstantiateSecondName = (string)whatToInstantiateSecond[secondArrayIndex];
        //                Object testObj = Resources.Load(objectToInstantiateSecondName);
        //                if (testObj != null)
        //                {
        //                    tempObj = (Instantiate(testObj,
        //                        new Vector2(11, -4.2f),
        //                        Quaternion.identity)) as GameObject;
        //                }
        //                else
        //                {
        //                    print("you wanted me to instantiate an object named " + objectToInstantiateSecondName + " but i did not find it");
        //                }
        //                timeElapsedInSecs += 1.07f;
        //                secondArrayIndex++;
        //                //print("Time in secs is " + timeElapsedInSecs);
        //                //print("Time elapsed is " + timeElapsed);
        //                print("signal that was just instantiated was :" + tempObj);
        //            }
        //        }
        //        if (timeElapsed > 51.14f)
        //        {
        //            SceneManager.LoadScene("Main");

        //        }
        //    }
        //    else
        //    {
        //        SceneManager.LoadScene("Tutorial_Page");
        //    }        
        //
    }
}
