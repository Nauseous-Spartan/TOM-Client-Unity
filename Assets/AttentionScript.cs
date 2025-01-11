using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Microsoft.MixedReality.Toolkit.Utilities;
using Microsoft.MixedReality.Toolkit.Audio;

public class AttentionScript : MonoBehaviour
{
    public GameObject module;
    public float angle = 10;
    Quaternion HeadAngleInitial;
    Quaternion HeadAngleCurrent;
    float currentDisplacement;

    // Start is called before the first frame update
    void Start()
    {
        HeadAngleInitial = CameraCache.Main.transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        HeadAngleCurrent = CameraCache.Main.transform.rotation;
        AttentionCheck();
    }

    private void AttentionCheck()
    {
        currentDisplacement = Quaternion.Angle(HeadAngleInitial, HeadAngleCurrent);
        if (currentDisplacement > angle)
        {
            module.SetActive(true);
        }
        else
        {
            module.SetActive(false);
        }
    }
}
