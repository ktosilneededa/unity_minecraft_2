using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class VoxelSwitch : MonoBehaviour
{
    public InputAction button1;
    public InputAction button2;
    public InputAction button3;
    public Sprite[] voxelPics;

    private Image image;
    private PlayerControl playercontrol;

    void Start()
    {
        image = GameObject.FindGameObjectWithTag("VoxelIcon").GetComponent<Image>();
        playercontrol = GetComponent<PlayerControl>();
    }

    private void OnEnable()
    {
        button1.Enable();
        button2.Enable();
        button3.Enable();
    }

    private void OnDisable()
    {
        button1.Disable();
        button2.Disable();
        button3.Disable();
    }

    void Update()
    {
        if (button1.triggered)
        {
            SwitchVoxel(1);
        }

        if (button2.triggered)
        {
            SwitchVoxel(2);
        }

        if (button3.triggered)
        {
            SwitchVoxel(3);
        }
    }

    void SwitchVoxel(int type)
    {
        Debug.Log(type);
        image.sprite = voxelPics[type - 1];
        playercontrol.voxelType = type - 1;
    }
}