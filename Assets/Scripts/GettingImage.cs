using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

public class GettingImage : MonoBehaviour
{
    // Specify the folder path where your images are located
    public string folderPath = "Assets/feature_maps_alexnet";

    public SortedList<int, Sprite> conv1_spriteRenderer = new SortedList<int, Sprite>();
    public SortedList<int, Sprite> maxpool1_spriteRenderer = new SortedList<int, Sprite>();
    public SortedList<int, Sprite> conv2_spriteRenderer = new SortedList<int, Sprite>();
    public SortedList<int, Sprite> maxpool2_spriteRenderer = new SortedList<int, Sprite>();
    public SortedList<int, Sprite> conv3_spriteRenderer = new SortedList<int, Sprite>();
    public SortedList<int, Sprite> conv4_spriteRenderer = new SortedList<int, Sprite>();
    public SortedList<int, Sprite> conv5_spriteRenderer = new SortedList<int, Sprite>();
    public SortedList<int, Sprite> maxpool3_spriteRenderer = new SortedList<int, Sprite>();



    public List<Sprite> conv1_spriteRenderer2 = new List<Sprite>();
    public List<Sprite> maxpool1_spriteRenderer2 = new List<Sprite>();
    public  List<Sprite> conv2_spriteRenderer2 = new List<Sprite>();
    public List<Sprite> maxpool2_spriteRenderer2 = new List<Sprite>();
    public List<Sprite> conv3_spriteRenderer2 = new List<Sprite>();
    public List<Sprite> conv4_spriteRenderer2 = new List<Sprite>();
    public List<Sprite> conv5_spriteRenderer2 = new List<Sprite>();
    public  List<Sprite> maxpool3_spriteRenderer2 = new List<Sprite>();

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
        // Check if the folder exists
        if (Directory.Exists(folderPath))
        {
            Debug.Log("folder exist");
            // Get all files (images) in the folder
            string[] imagePaths = Directory.GetFiles(folderPath, "*.png");
          
          


            // Load and display each image
            foreach (string imagePath in imagePaths)
            {
                byte[] fileData = File.ReadAllBytes(imagePath);
                Texture2D texture = new Texture2D(2, 2);
                texture.LoadImage(fileData); // Load image data into the texture

                Debug.Log("imagePath:" + imagePath);
                string filename = imagePath.Substring(28);
                Debug.Log("filename:" + filename);

                Sprite sprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), new Vector2(0.5f, 0.5f));
                sprite.texture.filterMode = FilterMode.Point;



                if (filename.StartsWith("0_"))
                {
                    Debug.Log("StartsWith 0");
                    int index = filename.IndexOf(".");
                    string fileNumber = filename.Substring(14, index - 14);
                    int fileNo = Convert.ToInt32(fileNumber);
                    conv1_spriteRenderer.Add(fileNo, sprite);

                }
                else if (filename.StartsWith("2_"))
                {
                    int index = filename.IndexOf(".");
                    string fileNumber = filename.Substring(14, index - 14);
                    int fileNo = Convert.ToInt32(fileNumber);
                    maxpool1_spriteRenderer.Add(fileNo, sprite);
                }
                else if (filename.StartsWith("3_"))
                {
                    int index = filename.IndexOf(".");
                    string fileNumber = filename.Substring(14, index - 14);
                    int fileNo = Convert.ToInt32(fileNumber);
                    conv2_spriteRenderer.Add(fileNo, sprite);
                }
                else if (filename.StartsWith("5_"))
                {
                    int index = filename.IndexOf(".");
                    string fileNumber = filename.Substring(14, index - 14);
                    int fileNo = Convert.ToInt32(fileNumber);
                    maxpool2_spriteRenderer.Add(fileNo, sprite);
                }
                else if (filename.StartsWith("6_"))
                {
                    int index = filename.IndexOf(".");
                    string fileNumber = filename.Substring(14, index - 14);
                    int fileNo = Convert.ToInt32(fileNumber);
                    conv3_spriteRenderer.Add(fileNo, sprite);
                }
                else if (filename.StartsWith("8_"))
                {
                    int index = filename.IndexOf(".");
                    string fileNumber = filename.Substring(14, index - 14);
                    int fileNo = Convert.ToInt32(fileNumber);
                    conv4_spriteRenderer.Add(fileNo, sprite);
                }
                else if (filename.StartsWith("10_"))
                {
                    int index = filename.IndexOf(".");
                    string fileNumber = filename.Substring(15, index - 15);
                    int fileNo = Convert.ToInt32(fileNumber);
                    conv5_spriteRenderer.Add(fileNo, sprite);
                }
                else if (filename.StartsWith("12_"))
                {
                    int index = filename.IndexOf(".");
                    string fileNumber = filename.Substring(15, index - 15);
                    int fileNo = Convert.ToInt32(fileNumber);
                    maxpool3_spriteRenderer.Add(fileNo, sprite);
                }

                // Create a new GameObject with a SpriteRenderer to display the image
                //GameObject imageObject = new GameObject(Path.GetFileNameWithoutExtension(imagePath));
                //imageObject.AddComponent<SpriteRenderer>().sprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), new Vector2(0.5f, 0.5f));

                // Optionally, you can position the images or perform other actions as needed
            }
        }
        else
        {
            Debug.LogError("Folder not found: " + folderPath);
        }
    }





}
