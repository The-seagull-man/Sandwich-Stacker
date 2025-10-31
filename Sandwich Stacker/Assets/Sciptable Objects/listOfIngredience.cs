using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "listOfIngredience", menuName = "ScriptableObjects/listOfIngredience")]
public class listOfIngredience : ScriptableObject
{
    public List<GameObject> theIngredienceList = new List<GameObject>();
}
