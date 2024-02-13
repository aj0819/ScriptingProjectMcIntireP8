using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiinearInterpolation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        // In this case, result = 4
        float result = Mathf.Lerp(3f, 5f, 0.5f);
        Vector3 from = new Vector3 (1f, 2f, 3f);
        Vector3 to = new Vector3 (5f, 6f, 7f);

        // Here result = (4, 5, 6)
        Vector3 result = Vector3.Lerp(from, to, 0.75f);
        GetComponent<Light>().intensity = Mathf.Lerp(GetComponent<Light>().intensity, 8f, 0.5f);
        Light.intensity = Mathf.Lerp(Light.intensity, 8f, 0.5f * Time.deltaTime);

    }
}
