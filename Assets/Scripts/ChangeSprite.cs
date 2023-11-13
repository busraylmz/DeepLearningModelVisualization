using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeSprite : MonoBehaviour
{

    public Image image;
    Sprite sprite;
    // Start is called before the first frame update
    void Start()
    {
        sprite = gameObject.GetComponent<Image>().sprite;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButtonClick()
    {
        image.sprite = sprite;
    }
}
