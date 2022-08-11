using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AlignPictureText : MonoBehaviour
{
    public ImageRotate imageRotate;
    public TextMeshProUGUI shouting;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (imageRotate.painting.transform.localEulerAngles.z <= 3f || imageRotate.painting.transform.localEulerAngles.z >= 357f)
        {
            shouting.color = new Color32(27, 191, 61, 255);
            shouting.text = new string("THAT'S GOOD!");
        }
        else
        {
            shouting.color = new Color32(239, 94, 38, 255);
            shouting.text = new string("NOT RIGHT!");
        }
    }
}
