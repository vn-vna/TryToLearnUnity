using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerController : MonoBehaviour
{
  [SerializeField]
  public RespawnControl Respawn;

  void Start()
  {
    var col = GetComponent<Collider2D>();
  }

  void Update()
  { }

  private void OnTriggerEnter2D(Collider2D collision)
  {
    var obj = collision.gameObject;
    if (obj.CompareTag("Player") && obj.TryGetComponent<PlayerController>(out var controller))
    {
      Respawn.LastSpawner = this.gameObject;
    }
  }

}
