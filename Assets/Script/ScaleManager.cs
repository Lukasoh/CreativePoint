using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleManager : MonoBehaviour
{
    public Vector2 referenceScale = new Vector2(1080, 2160);


    // Start is called before the first frame update
    void Start()
    {
        AdjustScale();
    }

    void AdjustScale()
    {
        float screenWidth = Screen.width;
        float screenHeight = Screen.height;

        if(screenWidth < referenceScale.x || screenHeight < referenceScale.y )
        {
            if(screenHeight <= 800)
            {
                transform.localScale = new Vector3(0.95f, 0.8f, 1);

            }
            else
            {
                transform.localScale = new Vector3(0.95f, 0.85f, 1);
            }

        }

        else if(screenWidth == 1440 && screenHeight == 2560)
        {
            transform.localScale = new Vector3(0.95f, 0.8f, 1);
        }

        

        
    }
}
