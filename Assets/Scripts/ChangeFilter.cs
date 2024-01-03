using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

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
       
        FilterAnimationController.instance.GetAnimationClip_2(gameObject);
        FilterAnimationController.instance.GetAnimationClip_3();
        FilterAnimationController.instance.GetAnimationClip_4();

        int i = 0;
        foreach (GameObject go in FilterAnimationController.instance.textFilters)
        {
            gameobjectfilter = go.transform.FindChild("FiltersText").gameObject;
            Debug.Log("gameoject:" + gameobjectfilter.transform.parent.name);
            if (go.name == gameObject.name)
            {
                FilterAnimationController.instance.featureMapList[i].GetComponent<Image>().color = Color.blue;
                Debug.Log("==:" + gameobjectfilter.transform.parent.name);
              //  gameobjectfilter.SetActive(true);
                gameobjectfilter2.GetComponent<TMP_Text>().text = gameobjectfilter.GetComponent<TMP_Text>().text;
                
            }
            else
            {
                FilterAnimationController.instance.featureMapList[i].GetComponent<Image>().color = Color.cyan;
                Debug.Log("!=:" + gameobjectfilter.transform.parent.name);
               //gameobjectfilter.SetActive(false);
            }
            i++;
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
