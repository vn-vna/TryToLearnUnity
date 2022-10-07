using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartUIController : MonoBehaviour
{
  public GameStatusControl GameStatusController;
  void Start()
  {

  }

  void Update()
  {
    if (Input.GetKeyDown(KeyCode.Return))
    {
      GameStatusController.ResumeGame();
      Canvas c = GetComponent<Canvas>();
      c.enabled = false;
    }
  }
}
