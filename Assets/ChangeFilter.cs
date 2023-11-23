using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ChangeFilter : MonoBehaviour
{
    
   


    public GameObject convFeature;
    public Sprite featuremapSprite;
    GameObject gameobjectfilter;
  public  GameObject gameobjectfilter2;

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

        foreach (GameObject go in FilterAnimationController.instance.textFilters)
        {
            gameobjectfilter = go.transform.FindChild("FiltersText").gameObject;
            Debug.Log("gameoject:" + gameobjectfilter.transform.parent.name);
            if (go.name == gameObject.name)
            {
                Debug.Log("==:" + gameobjectfilter.transform.parent.name);
                gameobjectfilter.SetActive(true);
                gameobjectfilter2.GetComponent<TMP_Text>().text = gameobjectfilter.GetComponent<TMP_Text>().text;
            }
            else
            {
                Debug.Log("!=:" + gameobjectfilter.transform.parent.name);
                gameobjectfilter.SetActive(false);
            }
               
        }



        //filterAnimation.filter = gameObject;
        //FilterAnimationController filterAnimation = new FilterAnimationController();
        //filterAnimation.GetAnimationClip_2(gameObject);
        //FilterAnimationController filterAnimation_1 = new FilterAnimationController();
        //filterAnimation_1.GetAnimationClip_3(horizontal);
        //FilterAnimationController filterAnimation_2 = new FilterAnimationController();
        //filterAnimation_2.GetAnimationClip_4(vertical);

    }
}
