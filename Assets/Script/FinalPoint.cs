using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalPoint : MonoBehaviour
{
    public Transform lockedObject;
    public int index;
    public LineController lc;

    void Start()
    {
        lc = GetComponentInParent<LineController>();
    }

    public bool AbleToConect(Transform obj)
    {
        return lc.CheckConection(this, obj) && lockedObject == null;
    }

}
