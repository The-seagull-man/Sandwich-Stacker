using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "listOfIngredience", menuName = "Scriptable Objects/listOfIngredience")]
public class listOfIngredience : ScriptableObject
{
    public List<GameObject> theIngredienceList = new List<GameObject>();
}
