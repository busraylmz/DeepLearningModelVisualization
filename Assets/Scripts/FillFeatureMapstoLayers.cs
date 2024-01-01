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
        Debug.Log("FillFeatureMaps");
        List<GameObject> gameObjectImageList = new List<GameObject>();
        if (gameObject.name.Equals("Conv1Cube"))
        {
            Debug.Log("conv1");
            spriteList = GettingImage.instance.conv1_spriteRenderer;


            Transform parentTransform = GridObjectCollection.transform;
         

            // Iterate through all children of the parent GameObject
            foreach (Transform childTransform in parentTransform)
            {
                // Access the child GameObject or do something with it
                GameObject childGameObject = childTransform.gameObject;
                gameObjectImageList.Add(childGameObject);
                Debug.Log("Child: " + childGameObject.name);
            }

            Debug.Log("gameObjectImageList.size::"+ gameObjectImageList.Count);
            int i = 0;
            foreach(Sprite featureSprite in spriteList)
            {
                gameObjectImageList[i].GetComponent<Image>().sprite = featureSprite;

                i++;
            }


        }
        else if (gameObject.name.Equals("MaxPool_1_Cube"))
        {
            Debug.Log("MaxPool_1_Cube");
            spriteList = GettingImage.instance.maxpool1_spriteRenderer;

            Transform parentTransform = GridObjectCollection.transform;
            // Iterate through all children of the parent GameObject
            foreach (Transform childTransform in parentTransform)
            {
                // Access the child GameObject or do something with it
                GameObject childGameObject = childTransform.gameObject;
                gameObjectImageList.Add(childGameObject);
                Debug.Log("Child: " + childGameObject.name);
            }
            Debug.Log("gameObjectImageList.size::" + gameObjectImageList.Count);
            int i = 0;
            foreach (Sprite featureSprite in spriteList)
            {
                gameObjectImageList[i].GetComponent<Image>().sprite = featureSprite;

                i++;
            }
        }
        else if (gameObject.name.Equals("Conv2Cube"))
        {
            Debug.Log("conv2");
            spriteList = GettingImage.instance.conv2_spriteRenderer;

            Transform parentTransform = GridObjectCollection.transform;
            // Iterate through all children of the parent GameObject
            foreach (Transform childTransform in parentTransform)
            {
                // Access the child GameObject or do something with it
                GameObject childGameObject = childTransform.gameObject;
                gameObjectImageList.Add(childGameObject);
                Debug.Log("Child: " + childGameObject.name);
            }
            Debug.Log("gameObjectImageList.size::" + gameObjectImageList.Count);
            int i = 0;
            foreach (Sprite featureSprite in spriteList)
            {
                gameObjectImageList[i].GetComponent<Image>().sprite = featureSprite;

                i++;
            }
        }
        else if (gameObject.name.Equals("MaxPool_2_Cube"))
        {
            Debug.Log("maxpool_2");
            spriteList = GettingImage.instance.maxpool2_spriteRenderer;

            Transform parentTransform = GridObjectCollection.transform;
            // Iterate through all children of the parent GameObject
            foreach (Transform childTransform in parentTransform)
            {
                // Access the child GameObject or do something with it
                GameObject childGameObject = childTransform.gameObject;
                gameObjectImageList.Add(childGameObject);
                Debug.Log("Child: " + childGameObject.name);
            }
            Debug.Log("gameObjectImageList.size::" + gameObjectImageList.Count);
            int i = 0;
            foreach (Sprite featureSprite in spriteList)
            {
                gameObjectImageList[i].GetComponent<Image>().sprite = featureSprite;

                i++;
            }
        }
        else if (gameObject.name.Equals("Conv3Cube"))
        {
            Debug.Log("conv3");
            spriteList = GettingImage.instance.conv3_spriteRenderer;

            Transform parentTransform = GridObjectCollection.transform;
            // Iterate through all children of the parent GameObject
            foreach (Transform childTransform in parentTransform)
            {
                // Access the child GameObject or do something with it
                GameObject childGameObject = childTransform.gameObject;
                gameObjectImageList.Add(childGameObject);
                Debug.Log("Child: " + childGameObject.name);
            }
            Debug.Log("gameObjectImageList.size::" + gameObjectImageList.Count);
            int i = 0;
            foreach (Sprite featureSprite in spriteList)
            {
                gameObjectImageList[i].GetComponent<Image>().sprite = featureSprite;

                i++;
            }
        }
        else if (gameObject.name.Equals("Conv4Cube"))
        {
            Debug.Log("conv4");
            spriteList = GettingImage.instance.conv4_spriteRenderer;

            Transform parentTransform = GridObjectCollection.transform;
            // Iterate through all children of the parent GameObject
            foreach (Transform childTransform in parentTransform)
            {
                // Access the child GameObject or do something with it
                GameObject childGameObject = childTransform.gameObject;
                gameObjectImageList.Add(childGameObject);
                Debug.Log("Child: " + childGameObject.name);
            }
            Debug.Log("gameObjectImageList.size::" + gameObjectImageList.Count);
            int i = 0;
            foreach (Sprite featureSprite in spriteList)
            {
                gameObjectImageList[i].GetComponent<Image>().sprite = featureSprite;

                i++;
            }
        }
        else if (gameObject.name.Equals("Conv5Cube"))
        {
            Debug.Log("conv5");
            spriteList = GettingImage.instance.conv5_spriteRenderer;

            Transform parentTransform = GridObjectCollection.transform;
            // Iterate through all children of the parent GameObject
            foreach (Transform childTransform in parentTransform)
            {
                // Access the child GameObject or do something with it
                GameObject childGameObject = childTransform.gameObject;
                gameObjectImageList.Add(childGameObject);
                Debug.Log("Child: " + childGameObject.name);
            }
            Debug.Log("gameObjectImageList.size::" + gameObjectImageList.Count);
            int i = 0;
            foreach (Sprite featureSprite in spriteList)
            {
                gameObjectImageList[i].GetComponent<Image>().sprite = featureSprite;

                i++;
            }
        }
        else if (gameObject.name.Equals("MaxPool_3_Cube"))
        {
            Debug.Log("MaxPool_3_Cube");
            spriteList = GettingImage.instance.maxpool3_spriteRenderer;

            Transform parentTransform = GridObjectCollection.transform;
            // Iterate through all children of the parent GameObject
            foreach (Transform childTransform in parentTransform)
            {
                // Access the child GameObject or do something with it
                GameObject childGameObject = childTransform.gameObject;
                gameObjectImageList.Add(childGameObject);
                Debug.Log("Child: " + childGameObject.name);
            }
            Debug.Log("gameObjectImageList.size::" + gameObjectImageList.Count);
            int i = 0;
            foreach (Sprite featureSprite in spriteList)
            {
                gameObjectImageList[i].GetComponent<Image>().sprite = featureSprite;

                i++;
            }
        }

    }
}
