using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public int size = 8;
    public Texture2D[] Cell = new Texture2D[64];
    public Texture2D[] CellState = new Texture2D[2];
}
