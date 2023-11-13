using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutputLinesGenerator : MonoBehaviour
{
    [SerializeField] private GameObject _lineRendererGO;

    private Dictionary<GameObject, Perceptron> spawnedLines;

    private void Awake()
    {
        spawnedLines = new Dictionary<GameObject, Perceptron>();
    }

    public void GenerateOutpuLines2NextLayer(List<Perceptron> nextLayerConnectedPerceptrons)
    {

        

        for (int i = 0; i < nextLayerConnectedPerceptrons.Count; i++)
        {
            var spawnedLineRendereGO = Instantiate(_lineRendererGO, transform.position, Quaternion.identity);
           // spawnedLineRendereGO


            LineRenderer spawnedLine = spawnedLineRendereGO.GetComponent<LineRenderer>();
            Vector3[] points = new Vector3[2];
            points[0]= (Vector3.zero);


            Vector3 endPoint = nextLayerConnectedPerceptrons[i].transform.position - transform.position;
            points[1] = (endPoint);
            spawnedLine.SetPositions(points);

            spawnedLines.Add(spawnedLineRendereGO, nextLayerConnectedPerceptrons[i]);
        }


    }


}
