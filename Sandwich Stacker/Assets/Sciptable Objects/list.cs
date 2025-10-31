using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "list", menuName = "Scriptable Objects/list")]
public class InList : ScriptableObject
{
    public List<GameObject> gameObjects = new();
}
