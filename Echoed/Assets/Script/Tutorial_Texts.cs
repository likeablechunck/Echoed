using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Tutorial_Texts : MonoBehaviour
{
    public float activeTime;
    public float deadTime;
    public Image textImage;

	// Use this for initialization
	void Start ()
    {
        textImage.enabled = false;
        	
	}
	
	// Update is called once per frame
	void Update ()
    {
        GameObject player = GameObject.Find("Player");
        Tutorial_Control TC = Camera.main.GetComponent<Tutorial_Control>();

        if(player != null)
        {
            if (TC.timeElapsed >= activeTime)
            {
                textImage.enabled = true;
            }
            if(TC.timeElapsed >= deadTime)
            {
                textImage.enabled = false;              
            }
        }

    }
}
