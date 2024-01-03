using Microsoft.MixedReality.Toolkit.Input;
using Microsoft.MixedReality.Toolkit.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConnectionVisualization1 : MonoBehaviour, IMixedRealityFocusHandler
{
   // [SerializeField] private GameObject _lineRendererGO;

    [SerializeField] string type = "";

   
   // [SerializeField] List<GameObject> spawnedLines = new List<GameObject>();
  //  ConnectionVisualization connectionVisualization =  ConnectionVisualization.Instance;
    public void OnFocusEnter(FocusEventData eventData)
    {
        Debug.Log("busraaaaaaaaaa");
        if(type == "flatten")
        {
            Debug.Log("busraaaaaaaaaa 222"+ ConnectionVisualization.Instance.spawnedLines_flatten.Count);
            for (int i = 0; i < ConnectionVisualization.Instance.spawnedLines_flatten.Count; i++)
            {
                Debug.Log("busraaaaaaaaaa 333");
                LineRenderer spawnedLine = ConnectionVisualization.Instance.spawnedLines_flatten[i].GetComponent<LineRenderer>();
                ConnectionVisualization.Instance.spawnedLines_flatten[i].transform.parent = gameObject.transform;
              


                Vector3[] points = new Vector3[2];
                points[0] = (Vector3.zero);


                Vector3 endPoint = ConnectionVisualization.Instance.layerPerceptrons_dense_1[i].transform.position - transform.position;
                points[1] = (endPoint);


                Debug.Log("endPoint");

                spawnedLine.SetPositions(points);
                ConnectionVisualization.Instance.spawnedLines_flatten[i].transform.localPosition = new Vector3(0, 0, 0);
            }
            
        }
        else if (type == "dense_1")
        {
            for (int i = 0; i < ConnectionVisualization.Instance.spawnedLines_dense_1.Count; i++)
            {
                Debug.Log("busraaaaaaaaaa 333");
                LineRenderer spawnedLine = ConnectionVisualization.Instance.spawnedLines_dense_1[i].GetComponent<LineRenderer>();
                ConnectionVisualization.Instance.spawnedLines_dense_1[i].transform.parent = gameObject.transform;



                Vector3[] points = new Vector3[2];
                points[0] = (Vector3.zero);


                Vector3 endPoint = ConnectionVisualization.Instance.layerPerceptrons_dense_2[i].transform.position - transform.position;
                points[1] = (endPoint);


                Debug.Log("endPoint");

                spawnedLine.SetPositions(points);
                ConnectionVisualization.Instance.spawnedLines_dense_1[i].transform.localPosition = new Vector3(0, 0, 0);
            }

        }
        else if (type == "dense_2")
        {
            for (int i = 0; i < ConnectionVisualization.Instance.spawnedLines_dense_2.Count; i++)
            {
                LineRenderer spawnedLine = ConnectionVisualization.Instance.spawnedLines_dense_2[i].GetComponent<LineRenderer>();
                ConnectionVisualization.Instance.spawnedLines_dense_2[i].transform.parent = gameObject.transform;



                Vector3[] points = new Vector3[2];
                points[0] = (Vector3.zero);


                Vector3 endPoint = ConnectionVisualization.Instance.layerPerceptrons_output[i].transform.position - transform.position;
                points[1] = (endPoint);


                Debug.Log("endPoint");

                spawnedLine.SetPositions(points);
                ConnectionVisualization.Instance.spawnedLines_dense_2[i].transform.localPosition = new Vector3(0, 0, 0);
            }


        }




        //Debug.Log("busraaaaaaaaaaaaa");


        //for (int i = 0; i < 20; i++)
        //{
        //    var spawnedLineRendereGO = Instantiate(_lineRendererGO, transform.position, Quaternion.identity);
        //    spawnedLineRendereGO.transform.parent = gameObject.transform;
        //    // spawnedLineRendereGO


        //    LineRenderer spawnedLine = spawnedLineRendereGO.GetComponent<LineRenderer>();
        //    Vector3[] points = new Vector3[2];
        //    points[0] = (Vector3.zero);


        //    Vector3 endPoint = layerPerceptrons[i].transform.position - transform.position;
        //    points[1] = (endPoint);

        //    spawnedLine.SetPositions(points);
        //   spawnedLines.Add(spawnedLineRendereGO);
        //}
    }

    public void OnFocusExit(FocusEventData eventData)
    {
       
    }

    // Uncomment this method if you want to handle focus exit
    // private void OnFocusExit()
    // {
    //     // Your code to handle focus exit
    //     Debug.Log("Object focus lost!");
    // }
}
