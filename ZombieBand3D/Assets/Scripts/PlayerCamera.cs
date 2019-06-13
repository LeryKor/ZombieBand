using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    public GameObject target;
    public float speedCamera;
    private Camera _zoomCam;

    private void Start()
    {
        _zoomCam = gameObject.GetComponent<Camera>();
        _zoomCam.orthographicSize = 18;
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, new Vector3(target.transform.position.x, target.transform.position.y, -10), speedCamera * Time.deltaTime);
    }
}
