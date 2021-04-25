using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAnimation : MonoBehaviour
{
  [SerializeField] private Animator umido;

  [SerializeField] private string apertura = "apertura";

  [SerializeField] private string chiusura = "chiusura";

  private void OnTriggerEnter(Collider other)
  {
    if (other.CompareTag("Player"))
    {
      umido.Play(apertura, 0, 0.0f);
    }
  }

  private void OnTriggerExit(Collider other)
  {
    umido.Play(chiusura, 0, 0.0f);
  }
}
