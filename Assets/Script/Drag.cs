using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : MonoBehaviour
{
    [SerializeField]
    private Transform finalPosition;

    [SerializeField]
    private Transform initialPosition;

    private Vector2 initPosition;
    private Vector2 mousePosition;

    private float deltaX, deltaY;

    private bool locked; 

    // Start is called before the first frame update
    void Start()
    {
        initPosition = transform.position;
    }

    private void OnMouseDown()
    {
        deltaX = Camera.main.ScreenToWorldPoint(Input.mousePosition).x - transform.position.x;
        deltaY = Camera.main.ScreenToWorldPoint(Input.mousePosition).y - transform.position.y;
    }

    private void OnMouseDrag()
    {
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector2(mousePosition.x - deltaX, mousePosition.y - deltaY);
    }

    private void OnMouseUp()
    {
           /* if (Mathf.Abs(transform.position.x - finalPosition.position.x) <= 0.5f &&
                Mathf.Abs(transform.position.y - finalPosition.position.y) <= 0.5f)
            {
                Debug.Log(finalPosition);
                transform.position = new Vector2(finalPosition.position.x, finalPosition.position.y);
            }
            else transform.position = new Vector2(initPosition.x, initPosition.y);*/
    }


}
