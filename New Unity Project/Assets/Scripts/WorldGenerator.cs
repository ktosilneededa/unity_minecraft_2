using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldGenerator : MonoBehaviour
{
    public GameObject stone;
    public GameObject dirt;
    public GameObject grass;

    private Vector3Int Size;

    public void CreateNew(Vector3 position)
    {
        if (position.y > 1)
        {
            var newVoxel = Instantiate(stone, position, Quaternion.identity);
        }
        else if (position.y == 1)
        {
            var newVoxel = Instantiate(grass, position, Quaternion.identity);
        }
        else
        {
            var newVoxel = Instantiate(dirt, position, Quaternion.identity);
        }
    }

    public void Start()
    {
        Size = new Vector3Int(128, 6, 128);
        StartCoroutine(GenerateWorld());
    }

    private IEnumerator GenerateWorld()
    {
        var map = new int[Size.x, Size.z];
        for (int x = 0; x < Size.x; x++) 
        {
            for(int z = 0; z < Size.z; z++)
            {
                map[x, z] = UnityEngine.Random.Range(1, Size.y);
            }
        }

        for (int i = 0; i < 70; i++)
        {
            map[UnityEngine.Random.Range(0, Size.x), UnityEngine.Random.Range(0, Size.z)] = Size.y * 30;
        }

            for (int k = 0; k < 7; k++)
        {
            var smoothMap = new int[Size.x, Size.z];
            for (int x = 0; x < Size.x; x++)
            {
                for (int z = 0; z < Size.z; z++)
                {
                    var sum = 0;
                    var c = 0;
                    for (int dx = -1; dx <= 1; dx++)
                    {
                        for (int dz = -1; dz <= 1; dz++)
                        {
                            var nx = x + dx;
                            var nz = z + dz;
                            if (nx >= 0 && nx < Size.x && nz >= 0 && nz < Size.z)
                            {
                                sum += map[nx, nz];
                                c += 1;
                            }
                        }
                    }
                    smoothMap[x, z] = sum / c;
                }
            }

            for (int x = 0; x < Size.x; x++)
            {
                for (int z = 0; z < Size.z; z++)
                {
                    map[x, z] = smoothMap[x, z];
                }
            }
        }


        var voxelsPerFrame = 500;
        var voxelsInFrameCounter = 0;
        for (int x = 0; x < Size.x; x++)
        {
            for (int z = 0; z < Size.z; z++)
            {
                var height = map[x, z];
                for (int y = 0; y < height; y++)
                {
                    var p = new Vector3Int(x, y, z);
                    CreateNew(p);
                    voxelsInFrameCounter +=1;
                    if (voxelsInFrameCounter >= voxelsPerFrame)
                    {
                        voxelsInFrameCounter = 0;
                        yield return new WaitForEndOfFrame();
                    }
                }
            }
        }
    }
}
