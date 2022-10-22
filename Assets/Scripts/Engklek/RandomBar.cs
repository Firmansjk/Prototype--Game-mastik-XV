using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;

public class RandomBar : MonoBehaviour
{
    [SerializeField] Transform trBar;
    public GameObject TargetBar;
    private int minRandomBar=-4;
    private int maxRandomBar=4;
    private int stepSize = 0;
    Vector3 originalPos;

    // Start is called before the first frame update
    void Start()
    {
        originalPos = TargetBar.transform.position;
        Randomizer();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Randomizer()
    {
        TargetBar.transform.position = originalPos;
        TargetBar.transform.position += new Vector3(Random.Range(minRandomBar, maxRandomBar)+stepSize, 0);
    }
}
