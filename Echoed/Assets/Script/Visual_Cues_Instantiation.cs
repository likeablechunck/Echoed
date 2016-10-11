using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Visual_Cues_Instantiation : MonoBehaviour
{


    public ArrayList whatToInstantiateFirst = new ArrayList();
    public float timeElapsedInSecs;
    GameObject tempObj;
    public float timeElapsed;
    int firstArrayIndex;
    

    // Use this for initialization
    void Start()
    {
        timeElapsedInSecs = -0.3f;
        timeElapsed = 0;
        firstArrayIndex = 0;
      


        //this will be the order of Obstacles that will appear on screen
        //First part of tutorial will only have the visual cues

        
        whatToInstantiateFirst.Add("Signals/Up_Arrow2");
        
        whatToInstantiateFirst.Add("Signals/Down_Arrow2");
        
        whatToInstantiateFirst.Add("Signals/Up_Arrow2");
       
        whatToInstantiateFirst.Add("Signals/Up_Arrow2");
        
        whatToInstantiateFirst.Add("Signals/Down_Arrow2");
        
        whatToInstantiateFirst.Add("Signals/Down_Arrow2");
       
        whatToInstantiateFirst.Add("Signals/Down_Arrow2");
        
        whatToInstantiateFirst.Add("Signals/Up_Arrow2");
       
        whatToInstantiateFirst.Add("Signals/Up_Arrow2");
       
        whatToInstantiateFirst.Add("Signals/Down_Arrow2");

    }


    // Update is called once per frame
    void Update()
    {

        timeElapsed = timeElapsed + Time.deltaTime;
        //print("Time elapsed is " + timeElapsed);
        GameObject player = GameObject.Find("Player");

        if (player != null)
        {
            if (timeElapsed >= 0 && timeElapsed < 33.9f)
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
