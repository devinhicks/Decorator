using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WithSilencer : RifleDecorator
{
    private float m_SilencerAccuracy = 5.0f;
    //Constructor
    public WithSilencer(IRifle rifle) : base(rifle) { }

    public override float GetAccuracy()
    {
        return base.GetAccuracy() + m_SilencerAccuracy;
    }

    public override GameObject LoadPart()
    {
        GameObject part = (GameObject)Resources.Load("Silencer");
        return part;
    }
}
