using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    protected Text text;

    public void Start()
    {
        text = this.gameObject.GetComponent<Text>();
    }

}
