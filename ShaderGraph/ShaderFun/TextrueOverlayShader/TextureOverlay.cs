using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureOverlay : MonoBehaviour
{
    private Renderer render;
    // Start is called before the first frame update
    void Start()
    {
        render = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.K))
        {
            float amount = render.material.GetFloat("_Amount");
            amount += 0.1f;

            render.material.SetFloat("_Amount", amount);    
        }
    }
}
