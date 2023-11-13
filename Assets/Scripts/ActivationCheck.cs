using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivationCheck : MonoBehaviour
{
    public GameObject go;
    bool flag = false;
    // Start is called before the first frame update
    public void ChangeActivation()
    {
        Debug.Log("ChangeActivation()" + gameObject.name);
        flag = !flag;
        go.SetActive(flag);
        if (flag == true)
            gameObject.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
        else
            gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
    }
}
