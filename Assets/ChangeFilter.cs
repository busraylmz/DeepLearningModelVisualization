using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeFilter : MonoBehaviour
{
    
   


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
       
        Debug.Log("busraaaaaaaaaaaaaa");
        FilterAnimationController.instance.GetAnimationClip_2(gameObject);
        FilterAnimationController.instance.GetAnimationClip_3();
        FilterAnimationController.instance.GetAnimationClip_4();
        //filterAnimation.filter = gameObject;
        //FilterAnimationController filterAnimation = new FilterAnimationController();
        //filterAnimation.GetAnimationClip_2(gameObject);
        //FilterAnimationController filterAnimation_1 = new FilterAnimationController();
        //filterAnimation_1.GetAnimationClip_3(horizontal);
        //FilterAnimationController filterAnimation_2 = new FilterAnimationController();
        //filterAnimation_2.GetAnimationClip_4(vertical);

    }
}
