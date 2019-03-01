using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HammerPull : MonoBehaviour {

    public bool pulling;
    public bool complete;

    public Image p1Pull, p2Pull;
    public Animator hammerPull;

    private void Start()
    {
        hammerPull = gameObject.GetComponent<Animator>();
    }

    public void Pulling()
    {
        p1Pull.enabled = true;
        p2Pull.enabled = true;
        pulling = true;
    }

	void Update () {
		if(pulling == true)
        {
            if (complete == false)
            {
                p1Pull.fillAmount -= 0.002f;
                p2Pull.fillAmount -= 0.002f;
            }
            if (Input.GetKeyDown(KeyCode.E))
            {
                p1Pull.fillAmount += 0.04f;
            }
            if (Input.GetKeyDown(KeyCode.O))
            {
                p2Pull.fillAmount += 0.04f;
            }
            if(p1Pull.fillAmount == 1 && p2Pull.fillAmount == 1)
            {
                complete = true;
                p1Pull.fillAmount = 1;
                p2Pull.fillAmount = 1;
                hammerPull.enabled = true;
            }
        }
        if (pulling == false)
        {
            p1Pull.fillAmount = 0f;
            p2Pull.fillAmount = 0f;
        }
	}

    public void HammerGet()
    {
        ItemPickup.instance.hammer = true;
        this.gameObject.SetActive(false);
    }
}
