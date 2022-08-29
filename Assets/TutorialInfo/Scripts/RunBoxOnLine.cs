using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunBoxOnLine : MonoBehaviour
{
    [SerializeField] private float _speed;
    private BoxCollider2D _boxCollider;
    private Vector2 screenBounds;

    // Start is called before the first frame update
    void Start()
    {
        _boxCollider = GetComponent<BoxCollider2D>();
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        transform.Translate(_speed * Time.deltaTime, 0, 0);
        if (transform.position[0] > screenBounds.x)
        {
            Destroy(gameObject);
        }
    }
}
