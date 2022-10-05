using UnityEngine;

public class SimpleCamController : MonoBehaviour
{
    private float _lookSpeed = 2f;
    private float _rotation = 0f;
    private float _speed = 2.0f;

    
    private void Start()
    {
        _rotation = transform.rotation.eulerAngles.y;
    }
    private void LateUpdate()
    {
        Vector3 pos = transform.position;

        if (Input.GetMouseButton(1))
        {
            _rotation += _lookSpeed * Input.GetAxis("Mouse X");
            transform.eulerAngles = new Vector3(0f, _rotation, 0f);
        }
        if (Input.GetKey("a"))
            transform.Translate(new Vector3(-_speed * Time.deltaTime, 0, 0));

        if (Input.GetKey("d"))
            transform.Translate(new Vector3(_speed * Time.deltaTime, 0, 0));

        if (Input.GetKey("w"))
            transform.Translate(new Vector3(0, 0, _speed * Time.deltaTime));

        if (Input.GetKey("s"))
            transform.Translate(new Vector3(0, 0, -_speed * Time.deltaTime));

    }

}