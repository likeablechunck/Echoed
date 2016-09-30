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
        for (int i = 1; i < 10; i++)
        {
            whatToInstantiateFirst.Add("Signals/Filled_Circle2");
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
        for (int j = 1; j < 4; j++)
        {
            //whatToInstantiateSecond.Add("Signals/Filled_Ciurcle2");
            //whatToInstantiateSecond.Add("Signals/Filled_Circle2");
            //whatToInstantiateSecond.Add("Signals/Filled_Circle2");
            whatToInstantiateSecond.Add("Signals/Down_Arrow2");
            //whatToInstantiateSecond.Add("Signals/Filled_Ciurcle2");
            //whatToInstantiateSecond.Add("Signals/Filled_Circle2");
            //whatToInstantiateSecond.Add("Signals/Filled_Circle2");
            whatToInstantiateSecond.Add("Signals/Up_Arrow2");
            //whatToInstantiateSecond.Add("Signals/Filled_Ciurcle2");
            //whatToInstantiateSecond.Add("Signals/Filled_Circle2");
            //whatToInstantiateSecond.Add("Signals/Filled_Circle2");
            whatToInstantiateSecond.Add("Signals/Up_Arrow2");
            //whatToInstantiateSecond.Add("Signals/Filled_Ciurcle2");
            //whatToInstantiateSecond.Add("Signals/Filled_Circle2");
            //whatToInstantiateSecond.Add("Signals/Filled_Circle2");
            whatToInstantiateSecond.Add("Signals/Down_Arrow2");
        }
        //print("array has " + whatToInstantiateFirst.Count + "elements");
        //print("elements : " + whatToInstantiateFirst);
    }


    // Update is called once per frame
    void Update()
    {

        timeElapsed = timeElapsed + Time.deltaTime;
        //print("Time elapsed is " + timeElapsed);
        GameObject player = GameObject.Find("Player");

        if (player != null)
        {
            if (timeElapsed >= 0 && timeElapsed < 34)
            {
                if ((timeElapsed - timeElapsedInSecs) > (1.304-0.3)*3f)
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
                    timeElapsedInSecs += (1.304f-0.3f)*3;
                    firstArrayIndex++;
                    print("signal that was just instantiated was :" + tempObj);
                }

            }
            if (timeElapsed >= 34 && timeElapsed <= 51.14f)
            {
                if ((timeElapsed - timeElapsedInSecs) > (3.21f-0.2f))
                {
                    //print("Time elapsed is: " + timeElapsed);
                    string objectToInstantiateSecondName = (string)whatToInstantiateSecond[secondArrayIndex];
                    Object testObj = Resources.Load(objectToInstantiateSecondName);
                    if (testObj != null)
                    {
                        tempObj = (Instantiate(testObj,
                            new Vector2(9.4f, -3.2f),
                            Quaternion.identity)) as GameObject;
                    }
                    else
                    {
                        print("you wanted me to instantiate an object named " + objectToInstantiateSecondName + " but i did not find it");
                    }
                    timeElapsedInSecs += (3.21f-0.2f);
                    secondArrayIndex++;
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
            SceneManager.LoadScene("Loose_Tutorial");
        }
    }
}
