using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragObject : MonoBehaviour
{
    public bool dragging;
    Vector3 screenPoint;
    Vector3 offset;
    int number;


    public LayerMask layerMask;

    public Transform firstTarget;
    public Transform target;
    public float speed;
    public bool active;

    public FinalPoint lastFinalPoint;

    public bool targetLocked;
    int locked = 0;

    void Awake()
    {
        lastFinalPoint = target.GetComponent<FinalPoint>();
    }

    void LateUpdate()
    {
        if (!dragging)
        {
            if (active && target != null)
            {
                transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
            }
            else
            {
                transform.position = Vector3.MoveTowards(transform.position, firstTarget.position, speed * Time.deltaTime);
                if (lastFinalPoint != null)
                {
                    lastFinalPoint.lockedObject = this.transform;
                }
            }
        }
    }

    private void OnMouseDown()
    {
        if (AbleToMove())
        {
            dragging = true;
            screenPoint = Camera.main.WorldToScreenPoint(transform.position);
            offset = transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
        }
    }

    private void OnMouseUp()
    {
        if (dragging == true)
        {
            dragging = false;
            if (targetLocked == true)
            {
                locked++;
            }
            CheckPosition();
            GameManager.instance.CheckVictory();
        }
    }

    private void OnMouseDrag()
    {
        if (dragging == true)
        {
            Vector3 currentScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
            Vector3 currentPosition = Camera.main.ScreenToWorldPoint(currentScreenPoint) + offset;
            transform.position = currentPosition;
            active = true;
        }
    }

    void CheckPosition()
    {
        Collider2D col = Physics2D.OverlapCircle(transform.position, 0.5f, layerMask);
        Debug.Log(col.name, col.gameObject);
        if(col.CompareTag ("finalPoint"))
        {
            FinalPoint fp = col.GetComponent<FinalPoint>();
            if (fp.AbleToConect(this.transform))
            {
                fp.lockedObject = this.transform;
                if (lastFinalPoint != null)
                {
                    lastFinalPoint.lockedObject = null;
                    target = null;
                    targetLocked = false;
                    locked--;
                }
                lastFinalPoint = fp;
                firstTarget = target = col.transform;
                targetLocked = true;
            }
        }
    }

    bool AbleToMove()
    {
        if (lastFinalPoint != null)
            return lastFinalPoint.lc.CheckFinalPoint(lastFinalPoint);
        return false;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(transform.position, 0.5f);
    }


}
