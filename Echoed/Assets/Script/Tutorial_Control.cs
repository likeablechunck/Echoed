using UnityEngine;
using System.Collections;

public class Tutorial_Control : MonoBehaviour
{
    public ArrayList whatToInstantiate = new ArrayList();
    public int n = 1;

	// Use this for initialization
	void Start ()
    {

    }
	
	// Update is called once per frame
	void Update ()
    {
        for (int i = 0; i < 10 * n ; i=i+10)
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

    }
}
