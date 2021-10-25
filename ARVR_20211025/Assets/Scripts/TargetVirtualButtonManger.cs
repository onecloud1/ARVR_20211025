using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class TargetVirtualButtonManger : MonoBehaviour
{
    [Header("要監聽的虛擬按鈕")]
    public VirtualButtonBehaviour vbbBite;
    [Header("要控制的動畫")]
    public Animator aniTarget;

    [Header("放顯示傷害預製物")]
    public GameObject popupDamage;
    [Header("顯示傷害位置的元件")]
    public Transform hudPos;

    private void Start()
    {
        vbbBite.RegisterOnButtonPressed(PlayBiteAnimation);
    }

    private void PlayBiteAnimation(VirtualButtonBehaviour vbb)
    {
        print(vbb.name);
    }


    void HPshow()
    {
        GameObject mObject = (GameObject)Instantiate(popupDamage, hudPos.position, Quaternion.identity);
        mObject.GetComponent<HUDPopup>().Value = -9999;
    }

}
