using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FilterAnimationController : MonoBehaviour
{
    public GameObject parent;
     GameObject beforeFilter = null;
    public GameObject beforeParent;
    Vector3 position = new Vector3(0, 0, 0);

    public List<GameObject> textFilters;

    List<string> clipname = new List<string>();

    public static FilterAnimationController instance;
    public GameObject vertical;
    public GameObject horizontal;

    // Start is called before the first frame update
    void Start()
    {
        if (instance != null && instance != this)
        {
            Destroy(this);
            return;
        }
        instance = this;

    }

    public AnimationClip GetAnimationClip()
    {

        AnimationCurve curve_position_x = AnimationCurve.Linear(0.0F, -1.34f, 4.0F, 1.33f);
        AnimationCurve curve_position_y = AnimationCurve.Linear(0.0F, 1.361f, 4.0F, 1.361f);
        AnimationCurve curve_position_z = AnimationCurve.Linear(0.0F, 0, 4.0f, 0f);

   //     AnimationCurve curve_rotation_y = AnimationCurve.Linear(0.0F, 0.0F, 4.0F, -150F);

        //AnimationCurve curve_scale_x = AnimationCurve.Linear(0.0F, 0.0F, 4.0F, 0.8F);
        //AnimationCurve curve_scale_y = AnimationCurve.Linear(0.0F, 0.0F, 4.0F, 0.8F);
        //AnimationCurve curve_scale_z = AnimationCurve.Linear(0.0F, 0.0F, 4.0F, 0.8F);

        AnimationClip clip = new AnimationClip();
        clip.legacy = true;


        clip.SetCurve("", typeof(Transform), "localPosition.x", curve_position_x);
        clip.SetCurve("", typeof(Transform), "localPosition.y", curve_position_y);
        clip.SetCurve("", typeof(Transform), "localPosition.z", curve_position_z);

       // clip.SetCurve("", typeof(Transform), "localEuler.y", curve_rotation_y);

        //clip.SetCurve("", typeof(Transform), "localScale.x", curve_scale_x);
        //clip.SetCurve("", typeof(Transform), "localScale.y", curve_scale_y);
        //clip.SetCurve("", typeof(Transform), "localScale.z", curve_scale_z);

        return clip;

    }
   // private Animation anim;


    Animation animfilter = null;
    public void GetAnimationClip_2(GameObject filter)
    {
        if(beforeFilter != null)
        {
            if(beforeFilter.name != filter.name)
            {
                beforeFilter.transform.parent = beforeParent.transform;
                beforeFilter.transform.position = position;
            }
        }

       
        beforeFilter = filter;
        position = beforeFilter.transform.position;
        filter.transform.parent = parent.transform;

        Debug.Log("busraaaaaaaaaaaaaa"+filter.name);
        // Vector3 position = new Vector3(-1.34f, 1.33f, 0f);
        float positionX = -1.29f;
        float positionY = 1.3f;

        if (animfilter != null)
        {
            if (animfilter.isPlaying)
                animfilter.Stop();
        }

        animfilter = filter.GetComponent<Animation>();
      

        float start = 0.0f;
        float stop = 6.0f;

        for (int i = 0; i < 27 ; i++)
        {
            

             AnimationCurve curve_position_x = AnimationCurve.Linear(start, positionX,stop, positionX + 2.01f);
            AnimationCurve curve_position_y = AnimationCurve.Linear(start, positionY, stop, positionY);
            //AnimationCurve curve_position_z = AnimationCurve.Linear(0.0F, 0, 4.0f, 0f);

            AnimationClip clip = new AnimationClip();
            clip.legacy = true;


            clip.SetCurve("", typeof(Transform), "localPosition.x", curve_position_x);
            clip.SetCurve("", typeof(Transform), "localPosition.y", curve_position_y);
            // clip.SetCurve("", typeof(Transform), "localPosition.z", curve_position_z);




            animfilter.AddClip(clip, "test"+i);
            clipname.Add("test" + i);
            positionY = positionY - 0.1f;
          //  start = start + 3.0f;
          //  stop = stop + 3.0f;
        }
       
        foreach(string name in clipname){

            animfilter.PlayQueued(name);
        }

   
    }

    Animation animhorizontal = null;
    public void GetAnimationClip_3()
    {
        //yatay
        // Vector3 position = new Vector3(-1.34f, 1.33f, 0f);
        float positionX = 0f;

        float positionY = 1.3f;

       


        if (animhorizontal != null)
        {
            if (animhorizontal.isPlaying)
                animhorizontal.Stop();
        }

        animhorizontal = horizontal.GetComponent<Animation>();


        float start = 0.0f;
        float stop = 6.0f;

        for (int i = 0; i < 27; i++)
        {


            AnimationCurve curve_position_x = AnimationCurve.Linear(start, positionX, stop, positionX + 2.72f);
            AnimationCurve curve_position_y = AnimationCurve.Linear(start, positionY, stop, positionY);
            AnimationCurve curve_position_z = AnimationCurve.Linear(start, -0.03f, stop, -0.03f);

            AnimationClip clip = new AnimationClip();
            clip.legacy = true;


            clip.SetCurve("", typeof(Transform), "localPosition.x", curve_position_x);
            clip.SetCurve("", typeof(Transform), "localPosition.y", curve_position_y);
             clip.SetCurve("", typeof(Transform), "localPosition.z", curve_position_z);




            animhorizontal.AddClip(clip, "test" + i);
            clipname.Add("test" + i);
            positionY = positionY - 0.1f;
            //  start = start + 3.0f;
            //  stop = stop + 3.0f;
        }

        foreach (string name in clipname)
        {

            animhorizontal.PlayQueued(name);
        }
    }

    Animation animvertical = null;
    public void GetAnimationClip_4()
    {
        //dikey

        // Vector3 position = new Vector3(-1.34f, 1.33f, 0f);
        float positionX = 0f;

        float positionY =-0.13f;
        //float scaleY = 2.75f;
        
        if (animvertical != null)
        {
            if (animvertical.isPlaying)
                animvertical.Stop();
        }

        animvertical = vertical.GetComponent<Animation>();


        float start = 0.0f;
        float stop = 6.0f;

        for (int i = 0; i < 27; i++)
        {


            AnimationCurve curve_position_x = AnimationCurve.Linear(start, positionX, stop, positionX );
            AnimationCurve curve_position_y = AnimationCurve.Linear(start, positionY, stop, positionY);
            AnimationCurve curve_position_z = AnimationCurve.Linear(start, -0.03f, stop, -0.03f);

            //AnimationCurve curve_scale_x = AnimationCurve.Linear(0.0F, 0.0F, 4.0F, 0.8F);
           // AnimationCurve curve_scale_y = AnimationCurve.Linear(start, scaleY, stop, scaleY);
            //AnimationCurve curve_scale_z = AnimationCurve.Linear(0.0F, 0.0F, 4.0F, 0.8F);


            AnimationClip clip = new AnimationClip();
            clip.legacy = true;


            clip.SetCurve("", typeof(Transform), "localPosition.x", curve_position_x);
            clip.SetCurve("", typeof(Transform), "localPosition.y", curve_position_y);
             clip.SetCurve("", typeof(Transform), "localPosition.z", curve_position_z);




            animvertical.AddClip(clip, "test" + i);
            clipname.Add("test" + i);
            positionY = positionY - 0.1f;
          //  scaleY = scaleY - (scaleY/27);
            //  start = start + 3.0f;
            //  stop = stop + 3.0f;
        }

        foreach (string name in clipname)
        {

            animvertical.PlayQueued(name);
        }
    }
}
