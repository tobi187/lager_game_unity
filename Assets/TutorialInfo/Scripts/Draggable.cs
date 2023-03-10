using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Draggable : MonoBehaviour
{
    private Vector2 initalPosition;

    private void Start()
    {
        initalPosition = transform.position;
    }

    public void ResetPosition()
    {
        transform.position = initalPosition;
    }
}
