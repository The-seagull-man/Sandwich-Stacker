using TMPro;
using UnityEngine;

public class Textscript : MonoBehaviour
{
    public floatvalues Scores;
    public TextMeshProUGUI shape;
    public TextMeshProUGUI correctness;

    

    void Start()
    {
        shape.text = ($"Centered score {Mathf.RoundToInt(Scores.HowTheFuckGoodStackedItIs).ToString()}");
        correctness.text = ($"Ingredient score {Mathf.RoundToInt(Scores.IngredientCorrectness).ToString()}");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
