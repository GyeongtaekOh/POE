using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {
    public float offset;
    public float speed;
    //x - min y - max
    public Vector2 minMaxXPosition;
    public Vector2 minMaxYPosition;
    private float screenWidth;
    private float screenHeight;
    private Vector3 cameraMove;

    public float fZoomSpeed = 1;
    public float fTargetOrtho;
    public float fSmoothSpeed = 2.0f;
    public float fMinOrtho = 1.0f;
    public float fMaxOrtho = 20.0f;

    // Use this for initialization
    void Start () {
        fTargetOrtho = Camera.main.orthographicSize;
        screenWidth = Screen.width;
        screenHeight = Screen.height;
        cameraMove.x = transform.position.x;
        cameraMove.y = transform.position.y;
        cameraMove.z = transform.position.z;
    }
	
	// Update is called once per frame
	void Update () {
        if ((Input.mousePosition.x > screenWidth - offset) && transform.position.x < minMaxXPosition.y)
        {
            cameraMove.x += MoveSpeed();
        }
        if ((Input.mousePosition.x < offset) && transform.position.x > minMaxXPosition.x)
        {
            cameraMove.x -= MoveSpeed();
        }
        if ((Input.mousePosition.y > screenHeight - offset) && transform.position.y < minMaxYPosition.y)
        {
            cameraMove.y += MoveSpeed();
        }
        if ((Input.mousePosition.y < offset) && transform.position.y > minMaxYPosition.x)
        {
            cameraMove.y -= MoveSpeed();
        }
        float scroll = Input.GetAxis("Mouse ScrollWheel");
        if (scroll != 0.0f)
        {
            fTargetOrtho -= scroll * fZoomSpeed;
            fTargetOrtho = Mathf.Clamp(fTargetOrtho, fMinOrtho, fMaxOrtho);
        }

        Camera.main.orthographicSize = Mathf.MoveTowards(Camera.main.orthographicSize, fTargetOrtho, fSmoothSpeed * Time.deltaTime);

        transform.position = cameraMove;
        

    }
    float MoveSpeed()
    {
        return speed * Time.deltaTime;
    }
}
