using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class TargetVirtualButtonManger : MonoBehaviour
{
    [Header("�n��ť���������s")]
    public VirtualButtonBehaviour vbbBite;
    [Header("�n����ʵe")]
    public Animator aniTarget;

    [Header("����ܶˮ`�w�s��")]
    public GameObject popupDamage;
    [Header("��ܶˮ`��m������")]
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
