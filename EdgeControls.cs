using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EdgeControls : MonoBehaviour {
    //global variables
    Renderer render;
    int pattern = 0;
	int cells = 0;

    // Start is called before the first frame update
    void Start() {
        render = GetComponent<Renderer>();
        render.material.shader = Shader.Find("CMPM163/Edge");
    }

    // Update is called once per frame
    void Update() {

		if (Input.GetKeyDown("left")) {
			--pattern;
        }
        if (Input.GetKeyDown("right")) {
			++pattern;
        }
		if (Input.GetKeyDown("up")) {
			++cells;
		}
		if (Input.GetKeyDown("down")) {
			--cells;
		}
		
		render.material.SetInt("_Pattern", pattern);
		render.material.SetInt("_NumCells", cells);

		render.material.SetFloat("_LookUpDistance", Input.mousePosition.x);
		render.material.SetFloat("_Mix", Input.mousePosition.y);

	}
}
