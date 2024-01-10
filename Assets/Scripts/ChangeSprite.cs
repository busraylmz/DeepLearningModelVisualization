using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeSprite : MonoBehaviour
{
    public GameObject inputImage;
    public string inputName_ ;
    public static string inputName ="";
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
        Debug.Log("ButtonClick");
        inputImage.GetComponent<SpriteRenderer>().sprite = sprite;
        inputName = inputName_;
        image.sprite = sprite;

        if(ModelButtonClick.layerType == "Lenet")
        {


          //  inputName = "2";
            foreach (GameObject go in GettingImage.instance.LenetLayers)
            {
                if(go.GetComponent<ActivationCheck>() != null)
                {
                    go.transform.localScale = new Vector3(1f, 1f, 1f);
                    go.GetComponent<ActivationCheck>().go.SetActive(false);
                    go.GetComponent<ActivationCheck>().flag = false;
                }
                else
                {
                    foreach(Sprite sprite in GettingImage.instance.dictList[inputName][4].Values)
                    {
                        go.GetComponent<SpriteRenderer>().sprite = sprite;

                    }
                }

            }

        }
        else
        {
          //  inputName = "cat";
            foreach (GameObject go in GettingImage.instance.AlexnetLayers)
            {
                go.transform.localScale = new Vector3(1f, 1f, 1f);
                go.GetComponent<ActivationCheck>().go.SetActive(false);
                go.GetComponent<ActivationCheck>().flag = false;

            }

        }
    }
}
