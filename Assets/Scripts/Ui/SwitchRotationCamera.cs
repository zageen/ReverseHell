using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class SwitchRotationCamera : MonoBehaviour
{

    public GameObject[] cameraList;

    private Animator anim;

    private bool isInverted;

    private void Awake()
    {
        anim = this.gameObject.GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P) && isInverted == false)
        {
            anim.Play("AnimSwitch");
            isInverted = true;
            cameraList[0].SetActive(false);
            cameraList[1].SetActive(true);

        }
        if (Input.GetKeyDown(KeyCode.P) && isInverted == true)
        {
            anim.Play("AnimSwitch2");
            isInverted = false;
            cameraList[0].SetActive(true);
            cameraList[1].SetActive(false);

        }
        
    }
}
