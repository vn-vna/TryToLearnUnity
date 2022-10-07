using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTextUpdate : MonoBehaviour
{
  public InventoryControl InventoryControl;
  private TMP_Text _text;
  private int _lastScore;
  // Start is called before the first frame update
  void Start()
  {
    _text = GetComponent<TMP_Text>();
    Debug.Log(_text);
  }

  // Update is called once per frame
  void Update()
  {
    if (_lastScore == InventoryControl.Score)
    {
      return;
    }

    _lastScore = InventoryControl.Score;
    _text.text = $"Score {_lastScore}";
  }
}
