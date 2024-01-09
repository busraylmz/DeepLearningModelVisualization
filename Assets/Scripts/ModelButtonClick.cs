using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelButtonClick : MonoBehaviour
{
    public GameObject goLenetModel;
    public GameObject goAlexnetModel;


    public static string layerType = "Lenet";

   // bool flag = false;
    // Start is called before the first frame update
    public void ChangeActivation()
    {
        Debug.Log("ChangeActivation()" + gameObject.name);
        //flag = !flag;

        if (gameObject.name.Contains("Lenet"))
        {
            goLenetModel.SetActive(true);
            goAlexnetModel.SetActive(false);
            layerType = "Lenet";
        }
        else
        {
            goLenetModel.SetActive(false);
            goAlexnetModel.SetActive(true);
            layerType = "Alexnet";
        }

        
      
    }
}
