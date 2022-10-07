using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoMoveTerrain : MonoBehaviour
{
  public Vector2 MoveDirection;
  public float ReverseTime;

  private float _lastReverse;
  private float _nextReverse;

  void Start()
  {

  }

  void Update()
  {
    if (Time.time > _nextReverse)
    {
      _lastReverse = Time.time;
      _nextReverse = _lastReverse + ReverseTime;
      MoveDirection = -MoveDirection;
    }

    Vector3 mov = MoveDirection;
    this.gameObject.transform.position += mov * Time.deltaTime;
  }
}
