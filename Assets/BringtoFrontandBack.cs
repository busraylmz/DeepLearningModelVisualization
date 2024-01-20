using Microsoft.MixedReality.Toolkit.UI;
using Microsoft.MixedReality.Toolkit.Utilities;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BringtoFrontandBack : MonoBehaviour
{

    private Vector3 imagePosition;
    private Quaternion imageRotation;
    private Vector3 scale;


    private GameObject ownParentCanvas;

    [SerializeField]
    private GameObject parentCanvas;

    [SerializeField]
    private GameObject closePanel;

    BoundingBox boundingBox;
    ObjectManipulator objectManipulator;
    RotationAxisConstraint rotationAxisConstraint;
    ConstraintManager constraintManager;

    bool flag = false; 

    // Start is called before the first frame update
    void Start()
    {
        imagePosition = gameObject.transform.position;
        imageRotation = gameObject.transform.rotation;
        scale = gameObject.transform.localScale;

        ownParentCanvas = gameObject.transform.parent.transform.gameObject;

        boundingBox = gameObject.GetComponent<BoundingBox>();
        objectManipulator = gameObject.GetComponent<ObjectManipulator>();
        rotationAxisConstraint = gameObject.AddComponent<RotationAxisConstraint>();
      
       // constraintManager = gameObject.AddComponent<ConstraintManager>();

        Debug.Log("IMAGE LOCAL POSITION:::" + imagePosition);
        Debug.Log("IMAGE LOCAL POSITION:::" + gameObject.transform.position);
    }

    // Update is called once per frame

    public void ChangeImagePosition(GameObject go)
    {
        //flag = !flag;

        //if (flag)
        //{
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
        // gameObject.transform.localRotation=InputDataExampleGizmo.gameObjectHead.transform.rotation;



      

         gameObject.transform.LookAt(Camera.main.transform);

        Quaternion quaternion = gameObject.transform.rotation;
        gameObject.transform.rotation = Quaternion.Euler(new Vector3(quaternion.eulerAngles.x * -1f, quaternion.eulerAngles.y + 180f, quaternion.eulerAngles.z));



           // new Quaternion(quaternion.eulerAngles.x * -1f, quaternion.eulerAngles.y+180f, quaternion.eulerAngles.z, )

       gameObject.transform.parent = parentCanvas.transform;
            Debug.Log("IMAGE LOCAL POSITION 222222:::" + gameObject.transform.position);


            boundingBox.enabled = true;
            objectManipulator.enabled = true;

            boundingBox.Target = gameObject;
            boundingBox.BoundsOverride= gameObject.GetComponent<BoxCollider>();

            rotationAxisConstraint.HandType = ManipulationHandFlags.OneHanded & ManipulationHandFlags.TwoHanded;
            rotationAxisConstraint.ConstraintOnRotation = AxisFlags.XAxis & AxisFlags.ZAxis;

        gameObject.GetComponent<Interactable>().enabled = false;
            
            closePanel.SetActive(true);

        //}
        //else
        //{

        //    closePanel.SetActive(false);
        //    boundingBox.enabled = false;
        //    objectManipulator.enabled = false;
        //    Debug.Log("IMAGE LOCAL POSITION flag 2:::" + flag);
        //    gameObject.transform.position = imagePosition;
        //    gameObject.transform.rotation = imageRotation;
        //    gameObject.transform.localScale = scale;

        //    gameObject.transform.parent = ownParentCanvas.transform;

        //}

    }


    public void BackOldPosition()
    {
        //flag = false;

        boundingBox.enabled = false;
        objectManipulator.enabled = false;

        Debug.Log("IMAGE LOCAL POSITION flag 2:::" + flag);
        gameObject.transform.position = imagePosition;
        gameObject.transform.rotation = imageRotation;
        gameObject.transform.localScale = scale;

        gameObject.transform.parent = ownParentCanvas.transform;
        closePanel.SetActive(false);
        gameObject.GetComponent<Interactable>().enabled = true;
    }

}
