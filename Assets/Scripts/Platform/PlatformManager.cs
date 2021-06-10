using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformManager : MonoBehaviour
{
    public GameObject Platform;
    public int PlatformAmmount;

    List<GameObject> Platforms;
    void Start()
    {
        Platforms = new List<GameObject>();

        for (int i = 0; i < PlatformAmmount; i++)
        {
            GameObject obj = (GameObject)Instantiate(Platform);
            obj.SetActive(false);
            Platforms.Add(obj);
        }
    }

    public GameObject GetPlatform()
    {
        for (int i = 0; i < PlatformAmmount; i++)
        {
            if (!Platforms[i].activeInHierarchy)
            {
                return Platforms[i];
            }
        }
        GameObject obj = (GameObject)Instantiate(Platform);
        obj.SetActive(false);
        Platforms.Add(obj);
        return obj;
    }

}
