using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

public class GettingImage : MonoBehaviour
{
    // Specify the folder path where your images are located
    public string folderPath = "Assets/feature_maps_alexnet_2";
    public List<Sprite> conv1_spriteRenderer = new List<Sprite>();
    public List<Sprite> maxpool1_spriteRenderer = new List<Sprite>();
    public  List<Sprite> conv2_spriteRenderer = new List<Sprite>();
    public List<Sprite> maxpool2_spriteRenderer = new List<Sprite>();
    public List<Sprite> conv3_spriteRenderer = new List<Sprite>();
    public List<Sprite> conv4_spriteRenderer = new List<Sprite>();
    public List<Sprite> conv5_spriteRenderer = new List<Sprite>();
    public  List<Sprite> maxpool3_spriteRenderer = new List<Sprite>();

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
            // Get all files (images) in the folder
            string[] imagePaths = Directory.GetFiles(folderPath, "*.png");
          
          


            // Load and display each image
            foreach (string imagePath in imagePaths)
            {
                byte[] fileData = File.ReadAllBytes(imagePath);
                Texture2D texture = new Texture2D(2, 2);
                texture.LoadImage(fileData); // Load image data into the texture

            //    Debug.Log("imagePath:" + imagePath);
                string filename = imagePath.Substring(30);
            //    Debug.Log("filename:" + filename);

                Sprite sprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), new Vector2(0.5f, 0.5f));

                if (filename.StartsWith("0_"))
                {
                   //conv1
              //      Debug.Log("0_:" + filename);
                    conv1_spriteRenderer.Add(sprite);

                }
                else if (filename.StartsWith("2_"))
                {
                    //maxpool_1
              //      Debug.Log("2_:" + filename);
                    maxpool1_spriteRenderer.Add(sprite);
                }
                else if (filename.StartsWith("3_"))
                {
               //     Debug.Log("3_:" + filename);
                    conv2_spriteRenderer.Add(sprite);
                }
                else if (filename.StartsWith("5_"))
                {
               //     Debug.Log("5_:" + filename);
                    maxpool2_spriteRenderer.Add(sprite);
                }
                else if (filename.StartsWith("6_"))
                {
               //     Debug.Log("6_:" + filename);
                    conv3_spriteRenderer.Add(sprite);
                }
                else if (filename.StartsWith("8_"))
                {
                //    Debug.Log("8_:" + filename);
                    conv4_spriteRenderer.Add(sprite);
                }
                else if (filename.StartsWith("10_"))
                {
               //     Debug.Log("10_:" + filename);
                    conv5_spriteRenderer.Add(sprite);
                }
                else if (filename.StartsWith("12_"))
                {
                 //   Debug.Log("12_:" + filename);
                    maxpool3_spriteRenderer.Add(sprite);
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
