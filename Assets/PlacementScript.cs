using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlacementScript : MonoBehaviour
{
  private void Start()
  {


    for (int i = 0; i < transform.childCount; i++)
    {
      transform.GetChild(i).position = GetPosition();
    }
  }
  int index = 1;
  int circleR = 4;
  float radius = 1f;
  Vector3 GetPosition()
  {
    float angle = index * Mathf.PI * 2f / circleR;
    Vector3 newPos = new Vector3(Mathf.Cos(angle) * radius, Mathf.Sin(angle) * radius, 0) + Vector3.up;
    index++;
    if (index == circleR)
    {
      circleR += circleR;
      index = 0;
      radius += radius * .5f;
    }
    return newPos;
  }
}
