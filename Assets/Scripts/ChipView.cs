using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChipView : MonoBehaviour
{
    [SerializeField]
    private Image _image = null;

    public void SetImage(Sprite sprite)
    {
        _image.sprite = sprite;
    }
    
    
        
    
}
