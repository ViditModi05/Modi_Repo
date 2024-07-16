using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

[CreateAssetMenu(menuName = "CustomUI/TextSO", fileName = "Text")]
public class TextSO : ScriptableObject
{ 
    [Header(" Data ")]
    public ThemeSO theme;

    [Header(" Settings ")]
    public TMP_FontAsset font;
    public float size;

    public HorizontalAlignmentOptions align;
  
}
