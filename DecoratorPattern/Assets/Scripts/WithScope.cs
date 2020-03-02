using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WithScope : RifleDecorator
{
    private float m_ScopeAccuracy = 20.0f;
    // Constructor
    public WithScope(IRifle rifle) : base(rifle) { }

    public override float GetAccuracy()
    {
        return base.GetAccuracy() + m_ScopeAccuracy;
    }

    public override GameObject LoadPart()
    {
        GameObject part = (GameObject)Resources.Load("Scope");
        return part;
    }
}
