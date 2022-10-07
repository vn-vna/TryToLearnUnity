using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTracker : MonoBehaviour
{
  public GameObject TrackedObject;
  public float CameraMoveSpeed = 1.3f;

  private Transform cameraTransform;
  private Transform playerTransform;

  private Vector2 _cameraVelocity;
  private bool _movable = true;

  void Start()
  {
    cameraTransform = transform;
    playerTransform = TrackedObject.transform;
  }

  void Update()
  {
    TransformCamera();
  }

  void TransformCamera()
  {
    if (!_movable)
    {
      return;
    }

    _cameraVelocity = playerTransform.position - cameraTransform.position;
    Vector3 mov = _cameraVelocity * CameraMoveSpeed * Time.deltaTime;
    cameraTransform.position += mov;
  }

  private void OnTriggerEnter2D(Collider2D collision)
  {
    if (collision.gameObject.layer == gameObject.layer)
    {
      _movable = false;
    }
  }

  private void OnTriggerExit2D(Collider2D collision)
  {
    if (collision.gameObject.layer == gameObject.layer)
    {
      _movable = true;
    }
  }
}
