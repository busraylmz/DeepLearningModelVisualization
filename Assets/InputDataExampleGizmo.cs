using Microsoft.MixedReality.Toolkit.Input;
using Microsoft.MixedReality.Toolkit.Utilities;
using UnityEngine;

    /// <summary>
    /// Attach this component to a game object to synchronize the objects position
    /// and rotation to the given input type. If the input data is not available,
    /// the component will hide the object by disabling all renderers.
    /// </summary>
    [AddComponentMenu("Scripts/MRTK/Examples/InputDataExampleGizmo")]
    public class InputDataExampleGizmo : MonoBehaviour
    {
        public InputSourceType sourceType;
        public Handedness handedness;
        private bool isDataAvailable = true;

        public static Vector3 HeadPosition;
        public static Quaternion HeadRotation;
        public static GameObject gameObjectHead;

    private void Start()
    {
        gameObjectHead = gameObject;
    }

    private void SetIsDataAvailable(bool value)
        {
            if (value != isDataAvailable)
            {
                foreach (var item in GetComponentsInChildren<Renderer>())
                {
                    item.enabled = value;
                }
            }
            isDataAvailable = value;
        }
        public void Update()
        {
            Ray myRay;
            if (InputRayUtils.TryGetRay(sourceType, handedness, out myRay))
            {
                transform.localPosition = myRay.origin;
                transform.localRotation = Quaternion.LookRotation(myRay.direction, Vector3.up);

                HeadPosition = transform.localPosition;
                HeadRotation = transform.localRotation;

            SetIsDataAvailable(true);
            }
            else
            {
                SetIsDataAvailable(false);
            }
        }
   }


