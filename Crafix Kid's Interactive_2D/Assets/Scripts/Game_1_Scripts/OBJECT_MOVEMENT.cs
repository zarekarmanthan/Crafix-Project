using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OBJECT_MOVEMENT : MonoBehaviour
{
    public Transform picture_Shadow;          //Right place of the object to be matched   

    private Vector2 start_Position;           // Startibg positon of the  object
    private float pos_X,                      // position in x direction
                  pos_Y;                      // position in y direction

    public bool is_Locked = false;

    private void Start()
    {
        start_Position = transform.position;  
    }

    private void OnMouseDown()
    {
        if (!is_Locked)
        {
            pos_X = Camera.main.ScreenToWorldPoint(Input.mousePosition).x - transform.position.x;
            pos_Y = Camera.main.ScreenToWorldPoint(Input.mousePosition).y - transform.position.y;
        }
    }

    private void OnMouseDrag()
    {
        if (!is_Locked)
        {
            Vector2 mouse_Position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector2(mouse_Position.x - pos_X,mouse_Position.y - pos_Y);
        }
    }

    private void OnMouseUp()
    {
        if (Mathf.Abs(transform.position.x - picture_Shadow.position.x) <= 0.5f &&
                 Mathf.Abs(transform.position.y - picture_Shadow.position.y) <= 0.5f)
        {
            transform.position = new Vector2(picture_Shadow.position.x , picture_Shadow.position.y);
            is_Locked = true;
        }
        else
        {
            transform.position = new Vector2(start_Position.x , start_Position.y);
        }
    }
}


