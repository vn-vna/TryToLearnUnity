using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TeleportController : MonoBehaviour
{
  public GameStatusControl GameController;
  public GameObject EngameCanvas;
  public InventoryControl InventoryController;
  public bool Finished = false;
  public string NextScene;
  public int Score;
  void Start()
  { }

  void Update()
  { }

  private void OnTriggerEnter2D(Collider2D collision)
  {
    var obj = collision.gameObject;
    if (Finished)
    {
      if (EngameCanvas.TryGetComponent<Canvas>(out var canvas))
      {
        canvas.enabled = true;
      }

      GameController.PauseGame();
      return;
    }
    if (obj.CompareTag("Player") && obj.TryGetComponent<PlayerController>(out var controller))
    {
      InventoryController.Score += Score;
      SceneManager.LoadScene(NextScene);
    }
  }
}
