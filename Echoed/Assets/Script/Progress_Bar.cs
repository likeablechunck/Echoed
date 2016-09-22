using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Progress_Bar : MonoBehaviour
{
    public Image progressTimeBar;
    public float totalTimeInCurrentScene;
    //public float totalTimeInSec;

	// Use this for initialization
	void Start ()
    {
        
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        progressTimeBar.fillAmount += fillingSpeed_Calculator(totalTimeInCurrentScene) *
            Time.deltaTime;
        if(progressTimeBar.fillAmount >1f)
        {
            this.enabled = false;

        }

	
	}
    public float fillingSpeed_Calculator(float totalTimeInSecs)
    {
        float fillingSpeed = 1 / totalTimeInSecs;
        return fillingSpeed;
    }
}
