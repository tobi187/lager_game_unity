using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragController : MonoBehaviour
{
    bool _isDragActive = false;
    Vector2 _screenPosition;
    Vector3 _worldPosition;
    Draggable _lastDragged;

    private void Awake()
    {
        var controllers = FindObjectsOfType<DragController>();
        if (controllers.Length > 1)
            Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (_isDragActive && (Input.touchCount == 1 && Input.GetTouch(0).phase == TouchPhase.Ended))
        {
            Drop();
            return;
        }

        if (Input.touchCount > 0)
        {
            _screenPosition = Input.GetTouch(0).position;
        }
        else return;

        _worldPosition = Camera.main.ScreenToWorldPoint( _screenPosition );

        if (_isDragActive)
            Drag();
        else
        {
            RaycastHit2D hit = Physics2D.Raycast(_worldPosition, Vector2.zero);
            if (hit.collider is not null)
            {
                var draggable = hit.transform.GetComponent<Draggable>();
                if (draggable is not null)
                {
                    _lastDragged = draggable;
                    InitDrag();
                }
            }
        }
    }

    private void Drop()
    {
        _isDragActive = false;
        _lastDragged.ResetPosition();
    }
    private void Drag() => _lastDragged.transform.position = new Vector2(_worldPosition.x, _worldPosition.y);

    private void InitDrag()
    {
        _isDragActive = true;
    }
}
