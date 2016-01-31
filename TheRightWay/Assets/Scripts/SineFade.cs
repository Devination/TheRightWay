using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SineFade : MonoBehaviour {

    public float fadeSpeed = 1f;
    public float fadeAmount = 1f;
    public MeshRenderer meshrenderer;
    public float minAlpha = 0f;
    public float phase = 1f;
    

    private Color originalColor;

	void Start ()
    {
        //originalColor = meshrenderer.material.GetColor("_TintColor");
	}
	
	// Update is called once per frame
	void Update ()
    {
        Color color = meshrenderer.material.GetColor("_TintColor");
        //color.a = Mathf.Abs(originalColor.a + (Mathf.Sin(Time.time * fadeSpeed) / fadeAmount));

        color.a = fadeAmount * Mathf.Sin((phase + Time.time) / fadeSpeed);

        if (color.a <= minAlpha)
        {
            color.a = minAlpha;
        }
        

        
        meshrenderer.material.SetColor("_TintColor", color);
	}
}
