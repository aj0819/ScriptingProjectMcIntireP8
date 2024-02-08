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
    }
}
