using UnityEngine;
using System.Collections;

public class Tutorial_Control : MonoBehaviour
{
    public ArrayList whatToInstantiate = new ArrayList();
    public int n = 3;
    public float i;

	// Use this for initialization
	void Start ()
    {

    }
	
	// Update is called once per frame
	void Update ()
    {
        i += Time.deltaTime;
        //this will be the order of signals that will appear on screen
        //empty empty fill fill arrow
        //This will repeat for 30secs
        for (int i = 0; i < 10 * n; i = i + 10)
        {
            whatToInstantiate.Add("Empty_Circle");
            whatToInstantiate.Add("Empty_Circle");
            whatToInstantiate.Add("Filled_Circle");
            whatToInstantiate.Add("Filled_Circle");
            whatToInstantiate.Add("Up_Arrow");
            whatToInstantiate.Add("Empty_Circle");
            whatToInstantiate.Add("Empty_Circle");
            whatToInstantiate.Add("Filled_Circle");
            whatToInstantiate.Add("Filled_Circle");
            whatToInstantiate.Add("Down_Arrow");

        }

        Instantiate(GameObject.Find((string)whatToInstantiate[(int)i]),new Vector2(11,-4.2f), Quaternion.identity);
        
    }

    
}
