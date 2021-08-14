using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Checker : MonoBehaviour {

    public GameObject TextStreaming;
    public GameObject Word;

    public void Start() {
        if (TextStreaming.GetComponent<Text>().text == "hi")
        {
            Debug.Log("HI GUYS");
        }
    }

}
