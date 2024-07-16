using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "CustomUI/ThemeSO", fileName = "Theme")]
public class ThemeSO : ScriptableObject
{
    [Header( "Primnary" )]
    public Color primary_bg;
    public Color columnPrimary_bg;
    public Color primary_text;

    [Header( "Secondary" )]
    public Color secondary_bg;
    public Color columnSecondary_bg;
    public Color secondary_text;

    [Header( "Teritiary" )]
    public Color teritiary_bg;
    public Color columnTeritiary_bg;
    public Color teritiary_text;

    [Header( "Other" )]
    public Color disable;


    public Color GetBackgroundColor( Style style)
    {
        // Checking wether the style is primary, secondary or teritiary and returning a value accordingly

        if(style == Style.Primnary)
        {
            return primary_bg;
        }
        else if(style == Style.Secondary)
        {
            return secondary_bg;
        }
        else if(style == Style.Teritiary)
        {
            return teritiary_bg;
        }

        return disable;
    }

    public Color GetTextColor(Style style)
    {
        // Checking wether the style is primary, secondary or teritiary and returning a value accordingly
       
        if(style == Style.Primnary)
        {
            return primary_text;
        }
        else if(style == Style.Secondary)
        {
            return secondary_text;
        }
        else if(style == Style.Teritiary)
        {
            return teritiary_text;
        }

        return disable; 
    }

    
}
