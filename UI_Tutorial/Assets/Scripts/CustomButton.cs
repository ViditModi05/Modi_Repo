using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class CustomButton : CustomUIComponent //acessing the abstract class
{
    [Header(" Data ")]
    public ThemeSO theme;
    public Style style;

    [Header(" Settings ")]
    public UnityEvent onClick;
    private Button button;
    private TextMeshProUGUI buttonText;

  public override void Setup()
  {
     //Grabbing all the references 

     button = GetComponentInChildren<Button>();
     buttonText = GetComponentInChildren<TextMeshProUGUI>();
  }

  public override void Configure()
  { 
     //Using the Style Script and the Theme Script to assign a Color to the text and the button

     ColorBlock cb = button.colors;
     cb.normalColor = theme.GetBackgroundColor(style);
     button.colors = cb;

     buttonText.color = theme.GetTextColor(style);
  }

  public void OnClick()
  {
    onClick.Invoke();
  }
  
}
