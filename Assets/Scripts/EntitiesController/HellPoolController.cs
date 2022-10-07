using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HellPoolController : MonoBehaviour
{
  void Start()
  {

  }

  void Update()
  {

  }

  void OnTriggerEnter2D(Collider2D collision)
  {
    var obj = collision.gameObject;
    if (obj.CompareTag("Player") && obj.TryGetComponent<PlayerController>(out var controller))
    {
      controller.KillPlayer();
    }
  }
}
