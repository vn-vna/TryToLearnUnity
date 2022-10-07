using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AutoHideTerrain : MonoBehaviour
{
  public float HideTimeout;

  private bool _isHeavy = false;
  private float _lastHeavy;

  void Start()
  {

  }

  void Update()
  {
    if (Time.time - _lastHeavy > HideTimeout)
    {
      if (_isHeavy)
      {
        BoxCollider2D col = GetComponent<BoxCollider2D>();
        col.enabled = false;
      }
      else
      {
        BoxCollider2D col = GetComponent<BoxCollider2D>();
        col.enabled = true;
      }
    }

  }

  public void TriggerHeavy()
  {
    _isHeavy = true;
    _lastHeavy = Time.time;
  }

  public void RemoveHeavy()
  {
    _isHeavy = false;
    _lastHeavy = Time.time;
  }
}
