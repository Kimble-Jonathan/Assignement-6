using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obsticle : MonoBehaviour
{
    int i = 0;
    int k = 0;

    // Update is called once per frame
    void Update()
    {

        if (i <= 1100)
        {
            transform.Translate(Vector3.forward * 0.005f * Time.deltaTime, Space.World);
            i++;
        }
        if(i==1100)
        {
            transform.Translate(-Vector3.forward * 0.005f * Time.deltaTime, Space.World);
            k++;
            if (k==1100)
            {
                i = 0;
                k = 0;
            }
        }
    }
}
    

