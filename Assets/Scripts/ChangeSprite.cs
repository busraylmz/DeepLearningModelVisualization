using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ChangeSprite : MonoBehaviour
{
    public GameObject inputImage;
    public string inputName_ ;
    public static string inputName ="";
    public Image image;
    Sprite sprite;
    [SerializeField]
    private TextMeshPro textMesh;
    [SerializeField]
    private TextMeshPro textMeshOutputCat;
    [SerializeField]
    private TextMeshPro textMeshOutputDog;
    [SerializeField]
    private TextMeshPro textMeshOutputShip;


    [SerializeField]
    private GameObject canvas;

    public GameObject lenetLayers;
    public GameObject alexnetLayers;

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
        textMesh.gameObject.SetActive(false);


        if (ModelButtonClick.layerType == "Lenet")
        {

            lenetLayers.SetActive(true);
            int denseNo = 0;
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
                    go.GetComponent<SpriteRenderer>().sprite = (GettingImage.instance.dictList[inputName])[4].Values[denseNo];
                    denseNo++;
                }

            }

        }
        else
        {
            alexnetLayers.SetActive(true);
            if(gameObject.name == "cat")
            {
                textMeshOutputDog.gameObject.SetActive(false);
                textMeshOutputShip.gameObject.SetActive(false);
                textMeshOutputCat.gameObject.SetActive(true);
            }
            else if (gameObject.name == "dog")
            {
                textMeshOutputDog.gameObject.SetActive(true);
                textMeshOutputShip.gameObject.SetActive(false);
                textMeshOutputCat.gameObject.SetActive(false);
            }
            else
            {
                textMeshOutputDog.gameObject.SetActive(false);
                textMeshOutputShip.gameObject.SetActive(true);
                textMeshOutputCat.gameObject.SetActive(false);
            }
            //  inputName = "cat";
            foreach (GameObject go in GettingImage.instance.AlexnetLayers)
            {
                go.transform.localScale = new Vector3(1f, 1f, 1f);
                go.GetComponent<ActivationCheck>().go.SetActive(false);
                go.GetComponent<ActivationCheck>().flag = false;
            }

            Transform parentTransform = canvas.transform;

            // Get all child transforms recursively
            BringtoFrontandBack[] allChildren = parentTransform.GetComponentsInChildren<BringtoFrontandBack>(true);

            // Exclude the parent transform itself
            foreach (BringtoFrontandBack image in allChildren)
            {
                if (image != parentTransform)
                {
                    // Do something with each child
                    image.BackOldPosition();
                    Debug.Log("Change sprite:::. Child: " + image.name);
                }
            }



            //Transform parentTransform = canvas.transform;
            //if (parentTransform.childCount != 0)
            //{

               
            //    foreach (Transform image in parentTransform)
            //    {
            //        // Access the child GameObject or do something with it
            //        image.gameObject.gameObject.GetComponent<BringtoFrontandBack>().BackOldPosition();
            //        Debug.Log("Child: " + image.name);
            //        Debug.Log("Change sprite:::. Child: " + image.name);
            //    }
            //}
        }
    }
}
