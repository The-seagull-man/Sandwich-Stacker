using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ListFloat", menuName = "Scriptable Objects/ListFloat")]
public class ListFloat : ScriptableObject
{
    public List<float> positions = new(); 
}
