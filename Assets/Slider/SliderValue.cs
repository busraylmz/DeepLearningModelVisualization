using Microsoft.MixedReality.Toolkit.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SliderValue : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnSliderUpdated(SliderEventData eventData)
    {
           InstantiateGO.instance.InstantiatingGO(2f);

        Debug.Log("djfhldshf" +  eventData.NewValue);
        Debug.Log("djfhldshf"+ float.Parse($"{ eventData.NewValue:F2}"));
    }
}
