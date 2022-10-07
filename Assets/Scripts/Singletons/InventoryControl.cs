using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.SearchService;
using UnityEngine;

[CreateAssetMenu(fileName = "Inventory Controller", menuName = "Scriptable Objects/Inventory Controller")]
public class InventoryControl : ScriptableObject
{
  public int Score = 0;
}
