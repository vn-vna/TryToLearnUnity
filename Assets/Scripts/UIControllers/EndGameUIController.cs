using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGameUIController : MonoBehaviour
{
  public GameStatusControl GameStatusController;
  void Start()
  {

  }

  void Update()
  {
    if (Input.GetKeyDown(KeyCode.Return))
    {
      SceneManager.LoadScene("Map1");
    }
  }
}
