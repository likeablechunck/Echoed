using UnityEngine;
using System.Collections;

public class Tutorial_Control : MonoBehaviour
{
    public ArrayList whatToInstantiate = new ArrayList();
    public int numberOfLoops;
    int timeElapsedInSecs;
    GameObject tempObj;
    public float timeElapsed;

	// Use this for initialization
	void Start ()
    {
        numberOfLoops = 3;
        timeElapsedInSecs = 0;
        timeElapsed = 0;
        for (int i = 0; i < 10 * numberOfLoops; i = i + 10)
        {
            whatToInstantiate.Add("Resources/Prefab/Empty_Circle");
            whatToInstantiate.Add("Resources/Prefab/Empty_Circle");
            whatToInstantiate.Add("Resources/Prefab/Filled_Circle");
            whatToInstantiate.Add("Resources/Prefab/Filled_Circle");
            whatToInstantiate.Add("Resources/Prefab/Up_Arrow");
            whatToInstantiate.Add("Resources/Prefab/Empty_Circle");
            whatToInstantiate.Add("Resources/Prefab/Empty_Circle");
            whatToInstantiate.Add("Resources/Prefab/Filled_Circle");
            whatToInstantiate.Add("Resources/Prefab/Filled_Circle");
            whatToInstantiate.Add("Resources/Prefab/Down_Arrow");
        }
        print("array has " + whatToInstantiate.Count + "elements");
        print("elements : " + whatToInstantiate);

    }

	
	// Update is called once per frame
	void Update ()
    {
        
        timeElapsed = timeElapsed + Time.deltaTime;
        //this will be the order of signals that will appear on screen
        //empty empty fill fill arrow
        //This will repeat for 30secs

        if ((timeElapsed - timeElapsedInSecs) > 1.0f)
        {
            //print("Time elapsed is: " + timeElapsed);
            string objectToInstantiateName = (string)whatToInstantiate[timeElapsedInSecs];
            GameObject objectToInstantiate = GameObject.Find(objectToInstantiateName);
            if (objectToInstantiate != null)
            {
                tempObj = (Instantiate(objectToInstantiate,
                    new Vector2(11, -4.2f),
                    Quaternion.identity)) as GameObject;
            } else
            {
                print("you wanted me to instantiate an object named " + objectToInstantiateName + " but i did not find it");
            }
            timeElapsedInSecs++;
            print("signal that was just instantiated was :" + tempObj);
            //print("Time elapsed is: " + timeElapsedInSecs);
        }
    }
}
