using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HammerPull : MonoBehaviour {

    public bool pulling;
    public bool complete;

    public Image p1Pull, p3Pull;
    public Animator hammerPull;

    public GameObject p1Trig, p3Trig;

    private void Start()
    {
        hammerPull = gameObject.GetComponent<Animator>();
        p3Pull.fillAmount = 0;
        p1Pull.fillAmount = 0;
    }

	void Update () {

            if (complete == false)
            {
                p1Pull.fillAmount -= 0.001f;
                p3Pull.fillAmount -= 0.001f;
            }
            if (Input.GetKeyDown(KeyCode.E) && p1Pull.enabled == true)
            {
                p1Pull.fillAmount += 0.06f;
            }
            if (Input.GetKeyDown(KeyCode.O) && p3Pull.enabled == true)
            {
                p3Pull.fillAmount += 0.06f;
            }
            if(p1Pull.fillAmount >= 0.95f && p3Pull.fillAmount >= 0.95f)
            {
                complete = true;
                p1Pull.fillAmount = 1;
                p3Pull.fillAmount = 1;
                hammerPull.SetTrigger("HammerGet");
            }
            if(p1Pull.enabled == false)
        {
            p1Pull.fillAmount = 0;
        }
            if(p3Pull.enabled == false)
        {
            p3Pull.fillAmount = 0;
        }
	}

    public void HammerGet()
    {
        ItemPickup.instance.hammer = true;
        this.gameObject.SetActive(false);
        Destroy(p1Pull);
        Destroy(p3Pull);
        Destroy(p1Trig);
        Destroy(p3Trig);
        Destroy(this.gameObject);
    }
}
