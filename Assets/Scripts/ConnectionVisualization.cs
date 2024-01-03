using Microsoft.MixedReality.Toolkit.Input;
using Microsoft.MixedReality.Toolkit.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConnectionVisualization : MonoBehaviour
{

    public static ConnectionVisualization Instance;

    [SerializeField] private GameObject _lineRendererGO;

    public List<GameObject> spawnedLines_flatten ;
    public List<GameObject> spawnedLines_dense_1 = new List<GameObject>();
    public List<GameObject> spawnedLines_dense_2 = new List<GameObject>();

    [SerializeField] GameObject dense_1_collection;
    [SerializeField] GameObject dense_2_collection;
    [SerializeField] GameObject output_collection;

    public List<GameObject> layerPerceptrons_dense_1 = new List<GameObject>();
    public List<GameObject> layerPerceptrons_dense_2 = new List<GameObject>();
    public List<GameObject> layerPerceptrons_output = new List<GameObject>();


    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        SpawendLayerLine();
    }

    // [SerializeField] List<GameObject> spawnedLines_flatten = new List<GameObject>();
    public void SpawendLayerLine()
    {

       // List<GameObject> list = new List<GameObject>();
        for (int i = 0; i < dense_1_collection.transform.childCount; i++)
        {
            layerPerceptrons_dense_1.Add(dense_1_collection.transform.GetChild(i).gameObject);
        }

        for (int i = 0; i < dense_2_collection.transform.childCount; i++)
        {
            layerPerceptrons_dense_2.Add(dense_2_collection.transform.GetChild(i).gameObject);
        }


        for (int i = 0; i < output_collection.transform.childCount; i++)
        {
            layerPerceptrons_output.Add(output_collection.transform.GetChild(i).gameObject);
        }


        spawnedLines_flatten = new List<GameObject>();
        for (int i = 0; i < 120; i++)
        {

            var spawnedLineRendereGO = Instantiate(_lineRendererGO, transform.position, Quaternion.identity);
            Debug.Log("spawend object::" + spawnedLineRendereGO);
            spawnedLines_flatten.Add(spawnedLineRendereGO);
            Debug.Log("added" );
            //  spawnedLineRendereGO.transform.parent = gameObject.transform;
            // spawnedLineRendereGO


            //LineRenderer spawnedLine = spawnedLineRendereGO.GetComponent<LineRenderer>();
            //Vector3[] points = new Vector3[2];
            //points[0] = (Vector3.zero);


            //Vector3 endPoint = new Vector3(1,1,1);
            //points[1] = (endPoint);

            //spawnedLine.SetPositions(points);

        }

        for (int i = 0; i < 84; i++)
        {
            var spawnedLineRendereGO = Instantiate(_lineRendererGO, transform.position, Quaternion.identity);
          //  spawnedLineRendereGO.transform.parent = gameObject.transform;
            // spawnedLineRendereGO


            //LineRenderer spawnedLine = spawnedLineRendereGO.GetComponent<LineRenderer>();
            //Vector3[] points = new Vector3[2];
            //points[0] = (Vector3.zero);


            //Vector3 endPoint = new Vector3(1, 1, 1);
            //points[1] = (endPoint);

            //spawnedLine.SetPositions(points);
            spawnedLines_dense_1.Add(spawnedLineRendereGO);
        }

        for (int i = 0; i < 10; i++)
        {
            var spawnedLineRendereGO = Instantiate(_lineRendererGO, transform.position, Quaternion.identity);
          //  spawnedLineRendereGO.transform.parent = gameObject.transform;
            // spawnedLineRendereGO


            //LineRenderer spawnedLine = spawnedLineRendereGO.GetComponent<LineRenderer>();
            //Vector3[] points = new Vector3[2];
            //points[0] = (Vector3.zero);


            //Vector3 endPoint = new Vector3(1, 1, 1);
            //points[1] = (endPoint);

            //spawnedLine.SetPositions(points);
            spawnedLines_dense_2.Add(spawnedLineRendereGO);
        }
    }

    // Uncomment this method if you want to handle focus exit
    // private void OnFocusExit()
    // {
    //     // Your code to handle focus exit
    //     Debug.Log("Object focus lost!");
    // }
}
