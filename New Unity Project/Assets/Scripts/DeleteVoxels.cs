using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteVoxels : MonoBehaviour
{
    public float impactRadius = 300;

    private bool aboutToExplode;
    public GameObject[] voxels;
    public GameObject voxelToDestroy;

    void Start()
    {
        aboutToExplode = GetComponent<ShrekController>().metPlayer;
    }

    // Update is called once per frame
    void Update()
    {
        if (aboutToExplode)
        {
            voxels = GameObject.FindGameObjectsWithTag("Voxel");
            foreach (GameObject v in voxels)
            {
                Destroy(v.gameObject);
            }
        }
    }
}
