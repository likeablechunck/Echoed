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
        timeElapsedInSecs = -0.3f;
        timeElapsed = 0;
        firstArrayIndex = 0;
        secondArrayIndex = 0;
        //StartCoroutine(Delay(5.608f));

        //this will be the order of Obstacles that will appear on screen
        for (int i = 1; i < 10; i++)
        {
            //whatToInstantiateFirst.Add("Signals/Filled_Circle2");
            //whatToInstantiateFirst.Add("Signals/Filled_Circle2");
            //whatToInstantiateFirst.Add("Signals/Filled_Circle2");
            //whatToInstantiateFirst.Add("Signals/Filled_Circle2");
            //whatToInstantiateFirst.Add("Signals/Filled_Circle2");
            whatToInstantiateFirst.Add("Signals/Up_Arrow2");
            //whatToInstantiateFirst.Add("Signals/Filled_Circle2");
            //whatToInstantiateFirst.Add("Signals/Filled_Circle2");
            //whatToInstantiateFirst.Add("Signals/Filled_Circle2");
            whatToInstantiateFirst.Add("Signals/Down_Arrow2");
            //whatToInstantiateFirst.Add("Signals/Filled_Circle2");
            //whatToInstantiateFirst.Add("Signals/Filled_Circle2");
            //whatToInstantiateFirst.Add("Signals/Filled_Circle2");
            whatToInstantiateFirst.Add("Signals/Up_Arrow2");
            //whatToInstantiateFirst.Add("Signals/Filled_Circle2");
            //whatToInstantiateFirst.Add("Signals/Filled_Circle2");
            //whatToInstantiateFirst.Add("Signals/Filled_Circle2");
            whatToInstantiateFirst.Add("Signals/Up_Arrow2");
            //whatToInstantiateFirst.Add("Signals/Filled_Circle2");
            //whatToInstantiateFirst.Add("Signals/Filled_Circle2");
            //whatToInstantiateFirst.Add("Signals/Filled_Circle2");
            whatToInstantiateFirst.Add("Signals/Down_Arrow2");
            //whatToInstantiateFirst.Add("Signals/Filled_Circle2");
            //whatToInstantiateFirst.Add("Signals/Filled_Circle2");
            //whatToInstantiateFirst.Add("Signals/Filled_Circle2");
            whatToInstantiateFirst.Add("Signals/Down_Arrow2");
            //whatToInstantiateFirst.Add("Signals/Filled_Circle2");
            //whatToInstantiateFirst.Add("Signals/Filled_Circle2");
            //whatToInstantiateFirst.Add("Signals/Filled_Circle2");
            whatToInstantiateFirst.Add("Signals/Down_Arrow2");
            //whatToInstantiateFirst.Add("Signals/Filled_Circle2");
            //whatToInstantiateFirst.Add("Signals/Filled_Circle2");
            //whatToInstantiateFirst.Add("Signals/Filled_Circle2");
            whatToInstantiateFirst.Add("Signals/Up_Arrow2");
            //whatToInstantiateFirst.Add("Signals/Filled_Circle2");
            //whatToInstantiateFirst.Add("Signals/Filled_Circle2");
            //whatToInstantiateFirst.Add("Signals/Filled_Circle2");
            whatToInstantiateFirst.Add("Signals/Up_Arrow2");
            //whatToInstantiateFirst.Add("Signals/Filled_Circle2");
            //whatToInstantiateFirst.Add("Signals/Filled_Circle2");
            //whatToInstantiateFirst.Add("Signals/Filled_Circle2");
            whatToInstantiateFirst.Add("Signals/Down_Arrow2");

        }
        //for (int j = 1; j < 4; j++)
        //{
        //    //whatToInstantiateSecond.Add("Signals/Filled_Ciurcle2");
        //    //whatToInstantiateSecond.Add("Signals/Filled_Circle2");
        //    //whatToInstantiateSecond.Add("Signals/Filled_Circle2");
        //    whatToInstantiateSecond.Add("Signals/Down_Arrow2");
        //    //whatToInstantiateSecond.Add("Signals/Filled_Ciurcle2");
        //    //whatToInstantiateSecond.Add("Signals/Filled_Circle2");
        //    //whatToInstantiateSecond.Add("Signals/Filled_Circle2");
        //    whatToInstantiateSecond.Add("Signals/Up_Arrow2");
        //    //whatToInstantiateSecond.Add("Signals/Filled_Ciurcle2");
        //    //whatToInstantiateSecond.Add("Signals/Filled_Circle2");
        //    //whatToInstantiateSecond.Add("Signals/Filled_Circle2");
        //    whatToInstantiateSecond.Add("Signals/Up_Arrow2");
        //    //whatToInstantiateSecond.Add("Signals/Filled_Ciurcle2");
        //    //whatToInstantiateSecond.Add("Signals/Filled_Circle2");
        //    //whatToInstantiateSecond.Add("Signals/Filled_Circle2");
        //    whatToInstantiateSecond.Add("Signals/Down_Arrow2");
        //}
        ////print("array has " + whatToInstantiateFirst.Count + "elements");
        ////print("elements : " + whatToInstantiateFirst);
    }


    // Update is called once per frame
    void Update()
    {

        timeElapsed = timeElapsed + Time.deltaTime;
        //print("Time elapsed is " + timeElapsed);
        GameObject player = GameObject.Find("Player");

        if (player != null)
        {
            if (timeElapsed >= 0 && timeElapsed < 40)
            {
                if ((timeElapsed - timeElapsedInSecs) > 7.824f)
                {
                    //print("Time elapsed is: " + timeElapsed);
                    string objectToInstantiateName = (string)whatToInstantiateFirst[firstArrayIndex];
                    //print("the signal I just instantiated was : " + objectToInstantiateName);
                    Object testObj = Resources.Load(objectToInstantiateName);
                    if (testObj != null)
                    {
                        tempObj = (Instantiate(testObj,
                            new Vector2(9.4f, -3.2f),
                            Quaternion.identity)) as GameObject;
                    }
                    else
                    {
                        print("you wanted me to instantiate an object named " + objectToInstantiateName + " but i did not find it");
                    }
                    timeElapsedInSecs += 5.216f;
                    firstArrayIndex++;
                    print("signal that was just instantiated was :" + tempObj);
                }

            }
            //if (timeElapsed >= 40 && timeElapsed <= 57.14f)
            //{
            //    //print("Time elapsed in secs is :" + timeElapsedInSecs);
            //    //timeElapsedInSecs = 30.2f;
            //    if ((timeElapsed - timeElapsedInSecs) > 4.28f)
            //    {
            //        //print("Time elapsed is: " + timeElapsed);
            //        string objectToInstantiateSecondName = (string)whatToInstantiateSecond[secondArrayIndex];
            //        Object testObj = Resources.Load(objectToInstantiateSecondName);
            //        if (testObj != null)
            //        {
            //            tempObj = (Instantiate(testObj,
            //                new Vector2(9.4f, -3.2f),
            //                Quaternion.identity)) as GameObject;
            //        }
            //        else
            //        {
            //            print("you wanted me to instantiate an object named " + objectToInstantiateSecondName + " but i did not find it");
            //        }
            //        timeElapsedInSecs += 4.28f;
            //        secondArrayIndex++;
            //        print("signal that was just instantiated was :" + tempObj);
            //    }
            //}
            if (timeElapsed > 84f)
            {
                SceneManager.LoadScene("Connector");

            }
        }
        else
        {
            SceneManager.LoadScene("Loose_Tutorial");
        }
    }
    //IEnumerator PartAInstantiation()
    //{
    //    Debug.Log("2.608 second wait is about to start");
    //    yield return StartCoroutine(Delay(3.608f));
        
    //}

    //IEnumerator Delay(float seconds)
    //{
    //    yield return new WaitForSeconds(seconds);
    //}
}
