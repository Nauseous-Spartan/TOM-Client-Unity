using System.Collections;
using System.Collections.Generic;
using UnityEngine;


using Microsoft.MixedReality.Toolkit.Utilities;
using Microsoft.MixedReality.Toolkit.Audio;


public class AttentionDetector : MonoBehaviour
{
    public float updateInterval;
    private float timer;

    private bool isHeadDataInitialized = false;

    public GameObject[] menus;

    private Vector3 HeadAngleInitial;
    private Vector3 HeadData;
    private bool isCheckHeadData = false;

    // Start is called before the first frame update
    void Start()
    {
        timer = updateInterval;
    }


    // Update is called once per frame
    void Update()
    {
        if (!isHeadDataInitialized)
        {
            HeadAngleInitial = CameraCache.Main.transform.rotation.eulerAngles;
            isHeadDataInitialized = true;
        }
        else
        {
            // timer -= Time.deltaTime;
            // if (timer <= 0)
            // {
            HeadData = AttentionDetectByHead();
            if (isCheckHeadData) AttentionCheck();
            // timer = updateInterval;
            // }
        }
    }


    private Vector3 AttentionDetectByHead()
    {
        Vector3 rotation = CameraCache.Main.transform.rotation.eulerAngles;
        return rotation;
    }

    private void AttentionCheck()
    {
        if (HeadData.x - HeadAngleInitial.x > 30 || HeadData.y - HeadAngleInitial.y > 30 || HeadData.z - HeadAngleInitial.z > 30)
        {
            Alert();
        }
    }

    private void Alert()
    {
        menus[1].SetActive(true);
    }

    public void StartButton()
    {
        // HeadAngleInitial = HeadData;
        menus[0].SetActive(false);
        isCheckHeadData = true;
    }
}



