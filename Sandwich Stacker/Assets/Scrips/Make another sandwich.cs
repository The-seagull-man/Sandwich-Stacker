using UnityEngine;
using UnityEngine.SceneManagement;

public class Makeanothersandwich : MonoBehaviour
{
    public InList Playerlist;
    public InList Randomingredients;

    public floatvalues scores;

    public ListFloat positions;


    public void comparerscene()
    {
        positions.positions.Clear();
        Playerlist.gameObjects.Clear();
        Randomingredients.gameObjects.Clear();
        SceneManager.LoadScene("GamePlay");
    }
    public void gameplayscene()
    {
        SceneManager.LoadScene("ComparerScene");
    }
    public void Menuscene()
    {
        positions.positions.Clear();
        Playerlist.gameObjects.Clear();
        Randomingredients.gameObjects.Clear();
    }
}
