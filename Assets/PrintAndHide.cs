using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    public Renderer rend;
    int i = 3;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        i++;
        Debug.Log(name + ":" + i);
        int j = Random.Range(150, 251);
        if (gameObject.tag == "Red" && i == 100)
        {
            gameObject.SetActive(false);
        }

        if (gameObject.tag == "Blue" && i == j)
        {
            rend = GetComponent<Renderer>();
            rend.enabled = false;
        }
    }
}
