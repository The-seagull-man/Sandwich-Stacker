using UnityEngine;
using static UnityEditor.PlayerSettings;

public class ImDoneSandwiching : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject spawner;
    public GameObject sandwichParent;
    public GameObject olive;
    public GameObject plate;
    [SerializeField] private float speed = 1.0f;
    private float step;
    private GameObject spawnedOlive;
    bool sandwichIsDone = false;
    private Component[] childrenTransforms;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        step = speed*Time.deltaTime;

        if (sandwichIsDone == true)
        {
            sandwichParent.transform.position = Vector3.MoveTowards(sandwichParent.transform.position, plate.transform.position, step);

        }
    }

    private void OnMouseDown()
    {
        spawner.GetComponent<Spawner>().StopSpawning();
        sandwichIsDone=true;
        GetComponent<SpriteRenderer>().sprite = null;
        childrenTransforms = sandwichParent.GetComponentsInChildren<Transform>();
        spawnedOlive = Instantiate(olive, childrenTransforms[childrenTransforms.Length - 1].transform);
        spawnedOlive.transform.position += new Vector3(0, 0.5f, 0);
    }

    

}
