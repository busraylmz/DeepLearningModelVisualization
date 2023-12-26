using Microsoft.MixedReality.Toolkit.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateGO : MonoBehaviour
{
    [SerializeField] GameObject goPrefab;

    List<GameObject> goList = new List<GameObject>();


    public static InstantiateGO instance=null;

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this);
        }
        else
        {
            instance = this;
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void InstantiatingGO(double value)
    {
        Debug.Log("value::" + value);
        float y = 0;

        if(goList.Count != 0)
        {
            foreach(GameObject go in goList)
            {
                Destroy(go);

            }
        }


        for(int i = 0; i<5; i++)
        {
            GameObject go = Instantiate(goPrefab);
            go.transform.localScale = new Vector3((float)value, (float)value);
            go.transform.position = new Vector3(0f, y, 0f);
            y = y + 2f;
            goList.Add(go);
        }
    }
    public void OnSliderUpdated(SliderEventData eventData)
    {
        InstantiatingGO(Math.Round(eventData.NewValue, 2) * 3f);
        Debug.Log("math sdfsdfdf"+Math.Round(12.1, 0));
        Debug.Log("djfhldshf" + eventData.NewValue);
        Debug.Log("djfhldshf" + float.Parse($"{ eventData.NewValue:F2}"));
    }
}
