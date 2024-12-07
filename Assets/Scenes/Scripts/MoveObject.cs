using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveObject : MonoBehaviour
{

    public Text testText;
    public GameObject Cube;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDown()
    {   
        float radius = 1.5f;
        float angle = Mathf.Deg2Rad * Random.Range(0,365);
        float x = radius * Mathf.Cos(angle);
        float y = Random.Range(-0.5f, 0.5f);
        float z = radius * Mathf.Sin(angle);
        Cube.transform.position = new Vector3(x, y, z);
        testText.text = $"angle: {angle} cos: {x} sin: {z} y: {y}";
    }
}
