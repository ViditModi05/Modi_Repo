using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class View : CustomUIComponent // accessing the abstract class
{
  public ViewSO viewData;

  [Header( "Game Objects ")]
  public GameObject containerTop;
  public GameObject containerCenter;
  public GameObject containerBottom;

  [Header(" Images ")]
  private Image imageTop;
  private Image imageCenter;
  private Image imageBottom;

  [Header(" Layout ")]
  private VerticalLayoutGroup verticalLayoutGroup;

  public override void Configure()
  {
    //Reading the padding and spacing values from the ViewSO script

    verticalLayoutGroup.padding = viewData.padding;
    verticalLayoutGroup.spacing = viewData.spacing;
    
    // Reading the Color values from the ViewSO script

    imageTop.color = viewData.theme.primary_bg;
    imageCenter.color = viewData.theme.secondary_bg;
    imageBottom.color = viewData.theme.teritiary_bg;  
  }

  public override void Setup()
  {
    //Grabbing all the references 

    verticalLayoutGroup = GetComponent<VerticalLayoutGroup>();
    imageTop = containerTop.GetComponent<Image>();
    imageCenter = containerCenter.GetComponent<Image>();
    imageBottom = containerBottom.GetComponent<Image>();

  }


  

}
