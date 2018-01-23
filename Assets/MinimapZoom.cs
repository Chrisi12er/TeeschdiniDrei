using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinimapZoom : MonoBehaviour
{

    Camera minimapCamera;
    int currentZoom;
    public int zoomMax;
    public int[] zoomArray;

	void Start ()
    {
        minimapCamera = this.GetComponent<Camera>();
        currentZoom = 2;
	}
	
	void Update ()
    {
        if (Input.GetKeyDown("j"))
        {
            currentZoom -= 1;
        }
        if (Input.GetKeyDown("k"))
        {
            currentZoom += 1;
        }

        if (currentZoom > zoomMax)
        {
            currentZoom = zoomMax;
        }
        else if (currentZoom < 1)
        {
            currentZoom = 1;
        }

        minimapCamera.orthographicSize = zoomArray[currentZoom - 1];

    }
}
