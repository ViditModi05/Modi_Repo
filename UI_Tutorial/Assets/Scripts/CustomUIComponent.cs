using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CustomUIComponent : MonoBehaviour //To use an abstract class it must be accessed from another class
{
  private void Awake()
  {
    Init(); //Calling the Init Method
  }

  public void Init()
  {
    Setup();     //Calling the Setup Method
    Configure(); //Calling the Configure Method
  }
 
  //Using the abstract class to inherit it from an another already exisiting class
  public abstract void Setup();
  public abstract void Configure();

  private void OnValidate()
  {
    Init();
  }

}
