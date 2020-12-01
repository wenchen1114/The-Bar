using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slideIn : MonoBehaviour
{
    public GameObject wine;
    float time = 0f;
    // Update is called once per frame
    void Update()
    {
        if (wine.activeSelf) {
            time += Time.deltaTime;
            if(time < 1) {
                wine.transform.position = Vector3.Lerp(wine.transform.position, wine.transform.position + (wine.transform.forward * 2f), Time.deltaTime * 2f);
            }
        }
    }
}
