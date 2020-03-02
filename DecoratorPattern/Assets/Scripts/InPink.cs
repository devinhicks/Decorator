using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InPink : RifleDecorator
{
    private float m_PinkAccuracy = 380.0f;
    //Constructor
    public InPink(IRifle rifle) : base(rifle) { }

    public override float GetAccuracy()
    {
        return base.GetAccuracy() + m_PinkAccuracy;
    }

    public override GameObject LoadPart()
    {
        GameObject part = (GameObject)Resources.Load("Pink");
        return part;
    }
}

