using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum playerTrig
{
    P1Trig,
    P3Trig
}

public class HammerTrig : MonoBehaviour {

    public playerTrig pTrig;
    private HammerPull hammerPull;

    private void Start()
    {
        hammerPull = GameObject.Find("Hammer").GetComponent<HammerPull>();
    }

    public void OnTriggerEnter(Collider other)
    {
        switch (pTrig)
        {
            case playerTrig.P1Trig:
                if(other.name == "Player1")
                {
                    hammerPull.p1Pull.enabled = true;
                }
                break;

            case playerTrig.P3Trig:
                if (other.name == "Player3")
                {
                    hammerPull.p3Pull.enabled = true;
                }
                break;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        switch (pTrig)
        {
            case playerTrig.P1Trig:
                if (other.name == "Player1")
                {
                    hammerPull.p1Pull.enabled = false;
                }
                break;

            case playerTrig.P3Trig:
                if (other.name == "Player3")
                {
                    hammerPull.p3Pull.enabled = false;
                }
                break;
        }
    }
}
