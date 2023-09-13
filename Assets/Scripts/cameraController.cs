using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour
{
    [SerializeField] GameObject camHolder;
    [SerializeField] GameObject cam;

    float pitch;

    [SerializeField] float sensitivity;

    // Update is called once per frame
    void Update()
    {
        Vector2 mouseDelta = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));

        pitch -= mouseDelta.y * sensitivity;
        pitch = Mathf.Clamp(pitch, -90, 90);

        camHolder.transform.localEulerAngles = Vector3.right * pitch;

        transform.Rotate(Vector3.up * mouseDelta.x * sensitivity);

        Cursor.visible = false;
    }
}
