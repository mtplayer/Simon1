using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    [Serializefield]
    Color buttonColor;

    Material material;

    // Start is called before the first frame update
    void Start()
    {
        material = GetComponent<Renderer>().material;
        buttonColor = material.color;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    Coroutine coroutine;
    internal void Activate()
    {
        if (coroutine != null) StopCoroutine(coroutine);
        coroutine = StartCoroutine(ChangeObjColor(GetComponent<Renderer>().material));
    }

    private IEnumerator ChangeObjColor(Material material)
    {
        material.color = Color.black;
        yield return new WaitForSeconds(1f);
        material.color = buttonColor;
    }
}
