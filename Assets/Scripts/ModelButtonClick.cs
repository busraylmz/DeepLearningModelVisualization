using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ModelButtonClick : MonoBehaviour
{
    public static string layerType = "Lenet";

    public GameObject goLenetModel;
    public GameObject goAlexnetModel;
    public void ChangeActivation()
    {
        Debug.Log("ChangeActivation()" + gameObject.name);

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
