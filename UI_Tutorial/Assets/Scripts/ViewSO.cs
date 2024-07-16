using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "CustomUI/ViewSO", fileName = "ViewSO")]
public class ViewSO : ScriptableObject  
{
    [Header( "Settings ")]
    public RectOffset padding;
    public float spacing;

    [Header( "Data" )]
    public ThemeSO theme;
 
}
