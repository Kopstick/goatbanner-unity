using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bg_Loop : MonoBehaviour
{
    [SerializeField] private RawImage img;
    [SerializeField] private float _x,_y;

    // Update is called once per frame
    void Update()
    {
        img.uvRect = new Rect(img.uvRect.position + new Vector2(_x,_y) * Time.deltaTime,img.uvRect.size);        
    }

}
