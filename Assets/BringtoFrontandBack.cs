using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BringtoFrontandBack : MonoBehaviour
{

    private Vector3 imagePosition;
    private Quaternion imageRotation;
    private Vector3 scale;

    bool flag = false; 

    // Start is called before the first frame update
    void Start()
    {
        imagePosition = gameObject.transform.localPosition;
        imageRotation = gameObject.transform.localRotation;
        scale = gameObject.transform.localScale;
        Debug.Log("IMAGE LOCAL POSITION:::" + imagePosition);
        Debug.Log("IMAGE LOCAL POSITION:::" + gameObject.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void ChangeImagePosition(string layerType,GameObject go,GameObject childGameObject)
    {
        flag = !flag;

        if (flag)
        {
            Debug.Log("IMAGE LOCAL POSITION flag 1:::" + flag);
            Debug.Log("head position:" + InputDataExampleGizmo.HeadPosition);
            Debug.Log("IMAGE LOCAL POSITION  1111:::" + imagePosition);


            //   gameObject.transform.position = InputDataExampleGizmo.HeadPosition;
            //gameObject.transform.rotation = InputDataExampleGizmo.HeadRotation;

            //switch (layerType)
            //{
            //    case "conv1":
            //        gameObject.transform.position = new Vector3(InputDataExampleGizmo.gameObjectHead.transform.position.x, InputDataExampleGizmo.gameObjectHead.transform.position.y - 0.03f, InputDataExampleGizmo.gameObjectHead.transform.position.z + 0.5f);
            //        break;
            //    case "maxpool1":
            //        gameObject.transform.position = new Vector3(InputDataExampleGizmo.gameObjectHead.transform.position.x, InputDataExampleGizmo.gameObjectHead.transform.position.y - 0.03f, InputDataExampleGizmo.gameObjectHead.transform.position.z + 0.5f);
            //        break;
            //    case "conv2":
            //        gameObject.transform.position = new Vector3(InputDataExampleGizmo.gameObjectHead.transform.position.x, InputDataExampleGizmo.gameObjectHead.transform.position.y - 0.03f, InputDataExampleGizmo.gameObjectHead.transform.position.z + 0.5f);
            //        break;
            //    case "maxpool2":
            //        gameObject.transform.position = new Vector3(InputDataExampleGizmo.gameObjectHead.transform.position.x, InputDataExampleGizmo.gameObjectHead.transform.position.y - 0.03f, InputDataExampleGizmo.gameObjectHead.transform.position.z + 0.5f);
            //        break;
            //    case "conv3":
            //        gameObject.transform.position = new Vector3(InputDataExampleGizmo.gameObjectHead.transform.position.x, InputDataExampleGizmo.gameObjectHead.transform.position.y - 0.03f, InputDataExampleGizmo.gameObjectHead.transform.position.z + 0.5f);
            //        break;
            //    default:             
            //        break;

            //}



            //  gameObject.transform.position = new Vector3(InputDataExampleGizmo.gameObjectHead.transform.position.x, InputDataExampleGizmo.gameObjectHead.transform.position.y - 0.03f, InputDataExampleGizmo.gameObjectHead.transform.position.z + 0.5f);


            // gameObject.transform.position = new Vector3(go.transform.position.x, go.transform.position.y, go.transform.position.z);

           
                
                Vector3 midpoint = (Camera.main.transform.position + go.transform.position) / 2f;
            gameObject.transform.position = new Vector3(midpoint.x, midpoint.y + 0.1f, midpoint.z);
            gameObject.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
            //  gameObject.transform.localRotation=InputDataExampleGizmo.gameObjectHead.transform.rotation;
            gameObject.transform.LookAt(Camera.main.transform);
            Debug.Log("IMAGE LOCAL POSITION 222222:::" + gameObject.transform.position);

        }
        else
        {

            RectTransform rt = childGameObject.GetComponent<RectTransform>();

            if (rt != null)
            {
                Debug.Log("ORDEEEEEEEERRRRRRRRRRR 0000000000000000");
                // Set the new sibling index
                rt.SetSiblingIndex(0);
            }
            Debug.Log("IMAGE LOCAL POSITION flag 2:::" + flag);
            gameObject.transform.localPosition = imagePosition;
            gameObject.transform.localRotation = imageRotation;
            gameObject.transform.localScale = scale;

        }

    }
}
