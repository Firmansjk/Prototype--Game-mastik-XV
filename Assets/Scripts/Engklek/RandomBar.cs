using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomBar : MonoBehaviour
{
    [SerializeField] Transform trBar;
    public Image TargetBar;
    private int minRandomBar= -50;
    private float maxRandomBar= 400;
    private int stepSize = 50;
    Vector3 originalPos;

    // Start is called before the first frame update
    void Start()
    {
        originalPos = TargetBar.rectTransform.anchoredPosition;
        Randomizer();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Randomizer()
    {
        TargetBar.rectTransform.anchoredPosition = originalPos;
        TargetBar.rectTransform.anchoredPosition += new Vector2(Random.Range(minRandomBar, maxRandomBar)+stepSize, 0);
    }
}
