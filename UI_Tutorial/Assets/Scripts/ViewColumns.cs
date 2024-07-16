using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ViewColumns : CustomUIComponent
{
  public ViewSO viewData;

  [Header( "Game Objects ")]
  public GameObject columncolumnContainerTop;
  public GameObject columncolumnContainerCenter;
  public GameObject columncolumnContainerBottom;

  [Header(" Images ")]
  private Image imageTop;
  private Image imageCenter;
  private Image imageBottom;

  [Header(" Layout ")]
  private HorizontalLayoutGroup horizontalLayoutGroup;

  public override void Configure()
  {
    //Reading the padding and spacing values from the ViewSO script

    horizontalLayoutGroup.padding = viewData.padding;
    horizontalLayoutGroup.spacing = viewData.spacing;
    
    // Reading the Color values from the ViewSO script

    imageTop.color = viewData.theme.columnPrimary_bg;
    imageCenter.color = viewData.theme.columnSecondary_bg;
    imageBottom.color = viewData.theme.columnTeritiary_bg;  
  }

  public override void Setup()
  {
    //Grabbing all the references 

    horizontalLayoutGroup = GetComponent<HorizontalLayoutGroup>();
    imageTop = columncolumnContainerTop.GetComponent<Image>();
    imageCenter = columncolumnContainerCenter.GetComponent<Image>();
    imageBottom = columncolumnContainerBottom.GetComponent<Image>();

  }


}
