using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touchMove : MonoBehaviour
{
    Vector2 moveDirection = Vector2.zero;
    //void Start()
    //{
    //    rb = GetComponent<Rigidbody2D>();
    //}

    void Update()
    {
        if (Input.touchCount>0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Moved)
            {
                Vector2 positionChange = touch.deltaPosition;
                positionChange.y = -positionChange.y;
                moveDirection = positionChange.normalized;
            }
        }
        transform.position += (Vector3)moveDirection * -10f * Time.deltaTime;
    }
   
}
