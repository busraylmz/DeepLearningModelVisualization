using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public GameObject _perceptronPrefab;


    [SerializeField] private float layerPadding = 0.5f;
    [SerializeField] private float perceptronPadding = .25f;


    [SerializeField] private int inputLayerPerceptronCount = 3;
    [SerializeField] private int outputLayerPerceptronCount = 2;
    [SerializeField] private List<int> hiddenLayerPerceptronCount;

    [SerializeField] private int hiddenLayerCount = 3;

    public Vector3 startPos = new Vector3(-1, 1.25f, 2);


    public List<List<Perceptron>> LayerList = new List<List<Perceptron>>();

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        InitAllVizSystem();


    }

    private void InitAllVizSystem()
    {
        //Instantiate(_perceptronPrefab, startPos, Quaternion.identity);
        GenerateLayers();
    }


    void GenerateLayers()
    {

        float x = startPos.x;
        float y = startPos.y;
        float z = startPos.z;

        List<Perceptron> InputLayerPerceptrons = new List<Perceptron>();

        for (int i = 0; i < inputLayerPerceptronCount; i++)
        {
            y  -= perceptronPadding;
            var spawnedPercetron = Instantiate(_perceptronPrefab, new Vector3(x, y, z), Quaternion.identity);

            
            InputLayerPerceptrons.Add(spawnedPercetron.GetComponent<Perceptron>());
        }

        LayerList.Add(InputLayerPerceptrons);


       // hiddenLayerPerceptronCount = 120;
        for (int i = 0; i < hiddenLayerCount; i++)
        {
            x += layerPadding;
            y = startPos.y;

            List<Perceptron> hiddenLayerPerceptrons = new List<Perceptron>();
            for (int j = 0; j < hiddenLayerPerceptronCount[i]; j++)
            {

                y -= perceptronPadding;
                var spawnedPercetron = Instantiate(_perceptronPrefab, new Vector3(x, y, z), Quaternion.identity);

                hiddenLayerPerceptrons.Add(spawnedPercetron.GetComponent<Perceptron>());
            }
           // hiddenLayerPerceptronCount = 84;
            LayerList.Add(hiddenLayerPerceptrons);

        }

        x += layerPadding;
        y = startPos.y;

        List<Perceptron> OutputLayerPerceptrons = new List<Perceptron>();
        for (int j = 0; j < outputLayerPerceptronCount; j++)
        {
            y -= perceptronPadding;
            var spawnedPercetron = Instantiate(_perceptronPrefab, new Vector3(x, y, z), Quaternion.identity);

            OutputLayerPerceptrons.Add(spawnedPercetron.GetComponent<Perceptron>());
        }

        LayerList.Add(OutputLayerPerceptrons);



        for (int k = 0; k < LayerList.Count; k++)
        {

            for (int i = 0; i < LayerList[k].Count; i++)
            {
                LayerList[k][i].OutputLinesGenerator.GenerateOutpuLines2NextLayer(LayerList[k + 1]);
            }

        }





    }

}
