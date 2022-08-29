using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBoxes : MonoBehaviour
{
    public GameObject _box;
    public float deployTime = 4.0F;
    private Vector2 screenBounds;
    // Start is called before the first frame update
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(Goboxes());
    }

    private void SpawnBox()
    {
        GameObject b = Instantiate(_box);
        b.transform.position = new Vector2(screenBounds.x * -2, 0.85f);
    }

    private IEnumerator Goboxes()
    {
        while (true)
        {
            yield return new WaitForSeconds(deployTime);
            SpawnBox();
        }
    }

    // Update is called once per frame
    //void Update()
    //{
        
    //}
}
