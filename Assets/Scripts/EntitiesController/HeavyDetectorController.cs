using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeavyDetectorController : MonoBehaviour
{
  void Start()
  {
  }

  void Update()
  {
  }

  private void OnTriggerEnter2D(Collider2D collision)
  {
    Debug.Log("TTrigger heavy");
    var controller = gameObject.transform.parent.gameObject.GetComponent<AutoHideTerrain>();
    controller.TriggerHeavy();
  }
  private void OnTriggerExit2D(Collider2D collision)
  {
    Debug.Log("TTrigger heavy");
    var controller = gameObject.transform.parent.gameObject.GetComponent<AutoHideTerrain>();
    controller.RemoveHeavy();
  }
}
