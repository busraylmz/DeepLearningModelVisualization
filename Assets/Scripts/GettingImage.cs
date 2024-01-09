using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

public class GettingImage : MonoBehaviour
{
    // Specify the folder path where your images are located

    public List<GameObject> layers;

    List<string> inputNameList = new List<string>();

    public SortedList<int, Sprite> conv1_spriteRenderer ;
    public SortedList<int, Sprite> maxpool1_spriteRenderer;
    public SortedList<int, Sprite> conv2_spriteRenderer;
    public SortedList<int, Sprite> maxpool2_spriteRenderer;
    public SortedList<int, Sprite> conv3_spriteRenderer;
    public SortedList<int, Sprite> conv4_spriteRenderer;
    public SortedList<int, Sprite> conv5_spriteRenderer;
    public SortedList<int, Sprite> maxpool3_spriteRenderer ;


    public Dictionary<string, List<SortedList<int, Sprite>>> dictList = new Dictionary<string, List<SortedList<int, Sprite>>>();


    public static GettingImage instance = null;

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


    void Start()
    {
        inputNameList.Add("cat");
        inputNameList.Add("dog");
        inputNameList.Add("ship");
        GetFiles();


     
    }



    private void GetFiles()
    {

        foreach(string inputName in inputNameList)
        {

            List<SortedList<int, Sprite>> listInput = new List<SortedList<int, Sprite>>();
           // bool inputList = CreateInputDict(inputName).TryGetValue(inputName, out listInput);

            string folderPath = System.IO.Path.Combine(Application.streamingAssetsPath, "feature_maps_alexnet","+"+inputName);
            // Check if the folder exists
            if (Directory.Exists(folderPath))
            {
                CreateLayerList();
                Debug.Log("folder exist");
                // Get all files (images) in the folder
                string[] imagePaths = Directory.GetFiles(folderPath, "*.png");




                // Load and display each image
                foreach (string imagePath in imagePaths)
                {
                    byte[] fileData = File.ReadAllBytes(imagePath);
                    Texture2D texture = new Texture2D(2, 2);
                    texture.LoadImage(fileData); // Load image data into the texture


                    int indexFileName = imagePath.IndexOf("+");

                    Debug.Log("imagePath:" + imagePath);
                    string filename = imagePath.Substring(indexFileName + inputName.Length+2);
                    Debug.Log("filename:" + filename);

                    Sprite sprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), new Vector2(0.5f, 0.5f));
                    sprite.texture.filterMode = FilterMode.Point;



                    if (filename.StartsWith("0_"))
                    {
                        Debug.Log("StartsWith 0");
                        int index = filename.IndexOf(".");
                        string fileNumber = filename.Substring(14, index - 14);
                        int fileNo = Convert.ToInt32(fileNumber);


                        Debug.Log("Addddddddddddddddd conv1::" + filename +"  " +fileNo);

                        conv1_spriteRenderer.Add(fileNo, sprite);
                     

                    }
                    else if (filename.StartsWith("2_"))
                    {
                        int index = filename.IndexOf(".");
                        string fileNumber = filename.Substring(14, index - 14);
                        int fileNo = Convert.ToInt32(fileNumber);

                        Debug.Log("Addddddddddddddddd maxpool1 ::" + filename + "  " + fileNo);
                        maxpool1_spriteRenderer.Add(fileNo, sprite);
                      
                    }
                    else if (filename.StartsWith("3_"))
                    {
                        int index = filename.IndexOf(".");
                        string fileNumber = filename.Substring(14, index - 14);
                        int fileNo = Convert.ToInt32(fileNumber);

                        Debug.Log("Addddddddddddddddd conv2:: " + filename + "  " + fileNo);
                        conv2_spriteRenderer.Add(fileNo, sprite);
                       
                    }
                    else if (filename.StartsWith("5_"))
                    {
                        int index = filename.IndexOf(".");
                        string fileNumber = filename.Substring(14, index - 14);
                        int fileNo = Convert.ToInt32(fileNumber);

                        Debug.Log("Addddddddddddddddd maxpool2:: " + filename + "  " + fileNo);

                        maxpool2_spriteRenderer.Add(fileNo, sprite);
                       
                    }
                    else if (filename.StartsWith("6_"))
                    {
                        int index = filename.IndexOf(".");
                        string fileNumber = filename.Substring(14, index - 14);
                        int fileNo = Convert.ToInt32(fileNumber);

                        Debug.Log("Addddddddddddddddd conv3:: " + filename + "  " + fileNo);
                        conv3_spriteRenderer.Add(fileNo, sprite);
                        
                    }
                    else if (filename.StartsWith("8_"))
                    {
                        int index = filename.IndexOf(".");
                        string fileNumber = filename.Substring(14, index - 14);
                        int fileNo = Convert.ToInt32(fileNumber);

                        Debug.Log("Addddddddddddddddd conv4:: " + filename + "  " + fileNo);
                        conv4_spriteRenderer.Add(fileNo, sprite);

                  
                    }
                    else if (filename.StartsWith("10_"))
                    {
                        int index = filename.IndexOf(".");
                        string fileNumber = filename.Substring(15, index - 15);
                        int fileNo = Convert.ToInt32(fileNumber);

                        Debug.Log("Addddddddddddddddd conv5:: " + filename + "  " + fileNo);
                        conv5_spriteRenderer.Add(fileNo, sprite);

                       
                    }
                    else if (filename.StartsWith("12_"))
                    {
                        int index = filename.IndexOf(".");
                        string fileNumber = filename.Substring(15, index - 15);
                        int fileNo = Convert.ToInt32(fileNumber);

                        Debug.Log("Addddddddddddddddd maxpool3:: " + filename + "  " + fileNo);
                        maxpool3_spriteRenderer.Add(fileNo, sprite);

                       
                    }
                   
                }
                listInput.Add(conv1_spriteRenderer);
                listInput.Add(maxpool1_spriteRenderer);
                listInput.Add(conv2_spriteRenderer);
                listInput.Add(maxpool2_spriteRenderer);
                listInput.Add(conv3_spriteRenderer);
                listInput.Add(conv4_spriteRenderer);
                listInput.Add(conv5_spriteRenderer);
                listInput.Add(maxpool3_spriteRenderer);

                dictList.Add(inputName, listInput);
            }
            else
            {
                Debug.LogError("Folder not found: " + folderPath);
            }
        }

        



    }



    //public Dictionary<string, List<SortedList<int, Sprite>>> CreateInputDict(string inputName, List<SortedList<int, Sprite>> listInput)
    //{
    //     Dictionary<string, List<SortedList<int, Sprite>>> inputList = new Dictionary<string, List<SortedList<int, Sprite>>>();
    //     inputList.Add(inputName, listInput);

    //     return inputList;

    //}


    public void CreateLayerList()
    {
       List<SortedList<int, Sprite>> inputList = new List<SortedList<int, Sprite>>();
       conv1_spriteRenderer = new SortedList<int, Sprite>();
     //   inputList.Add(conv1_spriteRenderer);
        maxpool1_spriteRenderer = new SortedList<int, Sprite>();
      //  inputList.Add(maxpool1_spriteRenderer);
      conv2_spriteRenderer = new SortedList<int, Sprite>();
     //   inputList.Add(conv2_spriteRenderer);
      maxpool2_spriteRenderer = new SortedList<int, Sprite>();
      //  inputList.Add(maxpool2_spriteRenderer);
       conv3_spriteRenderer = new SortedList<int, Sprite>();
      //  inputList.Add(conv3_spriteRenderer);
       conv4_spriteRenderer = new SortedList<int, Sprite>();
      //  inputList.Add(conv4_spriteRenderer);
       conv5_spriteRenderer = new SortedList<int, Sprite>();
     //   inputList.Add(conv5_spriteRenderer);
       maxpool3_spriteRenderer = new SortedList<int, Sprite>();
    //    inputList.Add(maxpool3_spriteRenderer);

     //   return inputList;
    }


}
