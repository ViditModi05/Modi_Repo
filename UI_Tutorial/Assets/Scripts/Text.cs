using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Text : CustomUIComponent // accessing the abstract class
{
  [Header(" Data ")]
  public TextSO textData;
  public Style style;

  [Header( " References ")]
  
 private TextMeshProUGUI textMeshProUGUI;


  public override void Configure()
  {
    //Reading the values from the TextSO script

    textMeshProUGUI.font= textData.font;
    textMeshProUGUI.fontSize = textData.size;
    textMeshProUGUI.alignment = (TextAlignmentOptions)textData.align;
    
    // Reading the Color values from the ViewSO script(Method 1)

    /* 
       textMeshProUGUI.color = textData.theme.primary_text;
       textMeshProUGUI.color = textData.theme.secondary_text;
       textMeshProUGUI.color = textData.theme.teritiary_text;
    */
    
    //Using the Style Script and the Theme Script to assign a Color to the text(Method 2)
    
    textMeshProUGUI.color = textData.theme.GetTextColor(style);

  }

  public override void Setup()
  {
    //Grabbing all the references 

    textMeshProUGUI = GetComponentInChildren<TextMeshProUGUI>();
    
  }


}
