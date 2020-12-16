using OculusSampleFramework;
using OVRTouchSample;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class PinchHand : MonoBehaviour
{
    public HandsManager handsManager;
    public GameObject panel;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


            if (handsManager.LeftHand.GetFingerIsPinching(OVRHand.HandFinger.Index))
            {
                panel.SetActive(true);
            }
            else if (handsManager.RightHand.GetFingerIsPinching(OVRHand.HandFinger.Index))
            {
                panel.SetActive(false);
            }
        
    }
}
