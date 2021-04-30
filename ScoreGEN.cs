using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreGEN : MonoBehaviour
{
  public Text scoreText;
  public string rifiuto;
  public string sbagliato1;
  public string sbagliato2;

  private void OnTriggerEnter(Collider other)
  {
    if(other.CompareTag(rifiuto))
    {
      scoreText.text = "<color=green>Ben fatto! </color>";
      Invoke("TextFadeOut", 3f);
    }
    if(other.CompareTag(sbagliato1))
    {
      scoreText.text = "<color=red>Bidone sbagliato!</color>";
      Invoke("TextFadeOut", 3f);
    }
    if(other.CompareTag(sbagliato2))
    {
      scoreText.text = "<color=red>Bidone sbagliato!</color>";
      Invoke("TextFadeOut", 3f);
    }
    if(other.CompareTag("palla"))
    {
      scoreText.text = "...Canestro?";
      Invoke("TextFadeOut", 3f);
    }
}

private void TextFadeOut()
  {
    scoreText.text = " ";
  }
}
