using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeFilter : MonoBehaviour
{
    FilterAnimationController filterAnimation = new FilterAnimationController();
    public GameObject parent;
    public GameObject vertical;
    public GameObject horizontal;

    public GameObject convFeature;
    public Sprite featuremapSprite;
    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void playFilterAnimation()
    {
        convFeature.transform.GetComponent<SpriteRenderer>().sprite = featuremapSprite;
        gameObject.transform.parent = parent.transform;
        Debug.Log("busraaaaaaaaaaaaaa");
        //filterAnimation.filter = gameObject;
        filterAnimation.GetAnimationClip_2(gameObject);
        filterAnimation.GetAnimationClip_3(horizontal);
        filterAnimation.GetAnimationClip_4(vertical);

    }
}
