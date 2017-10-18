using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testRtt : MonoBehaviour {
    [SerializeField]
    Shader shader; // assign mattatz/MaskBloom shader.
    Material material;
    // Use this for initialization
    void Start () {
        material = new Material(shader);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnRenderImage(RenderTexture src, RenderTexture dst)
    {
        var mask = RenderTexture.GetTemporary(src.width, src.height, 0, src.format);
        mask.filterMode = FilterMode.Bilinear;
        Graphics.Blit(src, mask, material, 0); // masking
 

        Graphics.Blit(mask, dst);
 
    }
 }
