using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

[CreateAssetMenu(fileName = "Respawn Coltroller", menuName = "Scriptable Objects/Respawn Coltroller")]
public class RespawnControl : ScriptableObject
{
  public GameObject LastSpawner;
  public GameObject Player;

  public void Respawn()
  {
    Player.transform.position = LastSpawner.transform.position;
  }
}
