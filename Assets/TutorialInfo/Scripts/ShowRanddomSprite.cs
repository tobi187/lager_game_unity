using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowRanddomSprite : MonoBehaviour
{
    public Sprite toyImage;
    public Sprite drinkImage;
    public Sprite sockImage;
    private SpriteRenderer _currentComponent;

    // Start is called before the first frame update
    void Start()
    {
        var randomNum = Random.Range(0, 3);
        _currentComponent = GetComponent<SpriteRenderer>();
        var currSprite = new Sprite[] { toyImage, drinkImage, sockImage }[randomNum];
        
        _currentComponent.sprite = currSprite;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
