using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GameStatusControll", menuName = "Scriptable Objects/Game Status Controll")]
public class GameStatusControl : ScriptableObject
{
  [SerializeField]
  private bool _isPaused = true;

  public bool IsPaused => _isPaused;

  public void PauseGame()
  {
    _isPaused = true;
  }

  public void ResumeGame()
  {
    _isPaused = false;
  }
}
