using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FillFeatureMapstoLayers : MonoBehaviour
{
    [SerializeField] GameObject GridObjectCollection;
    List<Sprite> spriteList = new List<Sprite>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void FillFeatureMaps()
    {
        if(ModelButtonClick.layerType == "Lenet")
        {





        }
        else
        {
            Debug.Log("FillFeatureMaps");
            List<GameObject> gameObjectImageList = new List<GameObject>();
            List<SortedList<int, Sprite>> layerImageList;
            Debug.Log("FillFeatureMaps--------------------------" + ChangeSprite.inputName);

            layerImageList = GettingImage.instance.dictList[ChangeSprite.inputName];

            Debug.Log("layer:" + layerImageList.Count);


            if (gameObject.name.Equals("Conv1Cube"))
            {
                Debug.Log("conv1");
                //spriteList = GettingImage.instance.conv1_spriteRenderer.Values;


                Transform parentTransform = GridObjectCollection.transform;
                //foreach (int featureNo in GettingImage.instance.dictList.Values)
                //{

                //    Debug.Log("featureNo: " + featureNo);


                //}
                // Iterate through all children of the parent GameObject
                foreach (Transform childTransform in parentTransform)
                {
                    // Access the child GameObject or do something with it
                    GameObject childGameObject = childTransform.gameObject;
                    gameObjectImageList.Add(childGameObject);
                    Debug.Log("Child: " + childGameObject.name);
                }
                Debug.Log("gameObjectImageList------.size::" + gameObjectImageList.Count);
                Debug.Log("gameObjectImageList.size::" + layerImageList[0].Values.Count);
                int i = 0;
                foreach (Sprite featureSprite in layerImageList[0].Values)
                {
                    //  Debug.Log("Texture name: " + featureSprite.texture.name);
                    gameObjectImageList[i].GetComponent<Image>().sprite = featureSprite;

                    i++;
                }


            }
            else if (gameObject.name.Equals("MaxPool_1_Cube"))
            {
                Debug.Log("MaxPool_1_Cube");
                //   spriteList = GettingImage.instance.maxpool1_spriteRenderer;

                Transform parentTransform = GridObjectCollection.transform;
                // Iterate through all children of the parent GameObject
                foreach (Transform childTransform in parentTransform)
                {
                    // Access the child GameObject or do something with it
                    GameObject childGameObject = childTransform.gameObject;
                    gameObjectImageList.Add(childGameObject);
                    Debug.Log("Child: " + childGameObject.name);
                }
                Debug.Log("gameObjectImageList.size::" + layerImageList[1].Values.Count);
                int i = 0;
                foreach (Sprite featureSprite in layerImageList[1].Values)
                {
                    gameObjectImageList[i].GetComponent<Image>().sprite = featureSprite;

                    i++;
                }
            }
            else if (gameObject.name.Equals("Conv2Cube"))
            {
                Debug.Log("conv2");
                //   spriteList = GettingImage.instance.conv2_spriteRenderer;

                Transform parentTransform = GridObjectCollection.transform;
                // Iterate through all children of the parent GameObject
                foreach (Transform childTransform in parentTransform)
                {
                    // Access the child GameObject or do something with it
                    GameObject childGameObject = childTransform.gameObject;
                    gameObjectImageList.Add(childGameObject);
                    Debug.Log("Child: " + childGameObject.name);
                }
                Debug.Log("gameObjectImageList.size::" + layerImageList[2].Values.Count);
                int i = 0;
                foreach (Sprite featureSprite in layerImageList[2].Values)
                {
                    gameObjectImageList[i].GetComponent<Image>().sprite = featureSprite;

                    i++;
                }
            }
            else if (gameObject.name.Equals("MaxPool_2_Cube"))
            {
                Debug.Log("maxpool_2");
                //  spriteList = GettingImage.instance.maxpool2_spriteRenderer;

                Transform parentTransform = GridObjectCollection.transform;
                // Iterate through all children of the parent GameObject
                foreach (Transform childTransform in parentTransform)
                {
                    // Access the child GameObject or do something with it
                    GameObject childGameObject = childTransform.gameObject;
                    gameObjectImageList.Add(childGameObject);
                    Debug.Log("Child: " + childGameObject.name);
                }
                Debug.Log("gameObjectImageList.size::" + layerImageList[3].Values.Count);
                int i = 0;
                foreach (Sprite featureSprite in layerImageList[3].Values)
                {
                    gameObjectImageList[i].GetComponent<Image>().sprite = featureSprite;

                    i++;
                }
            }
            else if (gameObject.name.Equals("Conv3Cube"))
            {
                Debug.Log("conv3");
                //spriteList = GettingImage.instance.conv3_spriteRenderer;

                Transform parentTransform = GridObjectCollection.transform;
                // Iterate through all children of the parent GameObject
                foreach (Transform childTransform in parentTransform)
                {
                    // Access the child GameObject or do something with it
                    GameObject childGameObject = childTransform.gameObject;
                    gameObjectImageList.Add(childGameObject);
                    Debug.Log("Child: " + childGameObject.name);
                }
                Debug.Log("gameObjectImageList.size::" + layerImageList[4].Values.Count);
                int i = 0;
                foreach (Sprite featureSprite in layerImageList[4].Values)
                {
                    gameObjectImageList[i].GetComponent<Image>().sprite = featureSprite;

                    i++;
                }
            }
            else if (gameObject.name.Equals("Conv4Cube"))
            {
                Debug.Log("conv4");
                // spriteList = GettingImage.instance.conv4_spriteRenderer;

                Transform parentTransform = GridObjectCollection.transform;
                // Iterate through all children of the parent GameObject
                foreach (Transform childTransform in parentTransform)
                {
                    // Access the child GameObject or do something with it
                    GameObject childGameObject = childTransform.gameObject;
                    gameObjectImageList.Add(childGameObject);
                    Debug.Log("Child: " + childGameObject.name);
                }
                Debug.Log("gameObjectImageList.size::" + layerImageList[5].Values.Count);
                int i = 0;
                foreach (Sprite featureSprite in layerImageList[5].Values)
                {
                    gameObjectImageList[i].GetComponent<Image>().sprite = featureSprite;

                    i++;
                }
            }
            else if (gameObject.name.Equals("Conv5Cube"))
            {
                Debug.Log("conv5");
                //spriteList = GettingImage.instance.conv5_spriteRenderer;

                Transform parentTransform = GridObjectCollection.transform;
                // Iterate through all children of the parent GameObject
                foreach (Transform childTransform in parentTransform)
                {
                    // Access the child GameObject or do something with it
                    GameObject childGameObject = childTransform.gameObject;
                    gameObjectImageList.Add(childGameObject);
                    Debug.Log("Child: " + childGameObject.name);
                }
                Debug.Log("gameObjectImageList.size::" + layerImageList[6].Values.Count);
                int i = 0;
                foreach (Sprite featureSprite in layerImageList[6].Values)
                {
                    gameObjectImageList[i].GetComponent<Image>().sprite = featureSprite;

                    i++;
                }
            }
            else if (gameObject.name.Equals("MaxPool_3_Cube"))
            {
                Debug.Log("MaxPool_3_Cube");
                // spriteList = GettingImage.instance.maxpool3_spriteRenderer;

                Transform parentTransform = GridObjectCollection.transform;
                // Iterate through all children of the parent GameObject
                foreach (Transform childTransform in parentTransform)
                {
                    // Access the child GameObject or do something with it
                    GameObject childGameObject = childTransform.gameObject;
                    gameObjectImageList.Add(childGameObject);
                    Debug.Log("Child: " + childGameObject.name);
                }
                Debug.Log("gameObjectImageList.size::" + layerImageList[7].Values.Count);
                int i = 0;
                foreach (Sprite featureSprite in layerImageList[7].Values)
                {
                    gameObjectImageList[i].GetComponent<Image>().sprite = featureSprite;

                    i++;
                }
            }



        }



        

    }
}
