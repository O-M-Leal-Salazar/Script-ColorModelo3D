using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorPicker : MonoBehaviour
{

    public Material[] BodyColorMat;
    Material CurrMat;
    Renderer renderer;

    // Use this for initialization
    void Start()
    {

        renderer = this.GetComponent<Renderer>();

    }

    // Update is called once per frame
    void Update()
    {

    }
    
    public void GrisMaterial()
    {
        renderer.material = BodyColorMat[0];
        CurrMat = renderer.material;
    }

    public void AmarilloMaterial()
    {
        renderer.material = BodyColorMat[1];
        CurrMat = renderer.material;
    }

    public void RojoMaterial()
    {
        renderer.material = BodyColorMat[2];
        CurrMat = renderer.material;
    }

    public void TransMaterial()
    {
        renderer.material = BodyColorMat[3];
        CurrMat = renderer.material;
    }
}
