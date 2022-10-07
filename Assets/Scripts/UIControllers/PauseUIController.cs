using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseUIController : MonoBehaviour
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

    if (Input.GetKeyDown(KeyCode.Escape))
    {
      GameStatusController.PauseGame();
      Canvas c = GetComponent<Canvas>();
      c.enabled = true;
    }
  }
}
