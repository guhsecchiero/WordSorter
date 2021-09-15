using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineController : MonoBehaviour
{
    public FinalPoint[] finalPoints;


    public bool CheckFinalPoint(FinalPoint fp)
    {
        bool ableToMove = true;
        if (fp.index + 1 < finalPoints.Length)
        {
            for (int i = fp.index + 1; i < finalPoints.Length; i++)
            {
                if (finalPoints[i].lockedObject != null)
                {
                    ableToMove = false;
                    break;
                }
            }
        }
        return ableToMove;
    }

    public bool CheckConection(FinalPoint fp, Transform obj)
    {
        bool ableToConect = true;
        if (fp.index > 0)
        {
            for (int i = 0; i < fp.index; i++)
            {
                if (finalPoints[i].lockedObject == null)
                {
                    ableToConect = false;
                    break;
                }
                else if (finalPoints[i].lockedObject == obj)
                {
                    ableToConect = false;
                    break;
                }
            }
        }
        Debug.Log(fp.index);
        return ableToConect;

    }

}
