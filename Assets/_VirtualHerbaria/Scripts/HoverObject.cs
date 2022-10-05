using UnityEngine;

public class HoverObject : MonoBehaviour
{
    [SerializeField] private GameObject _callout;
    private Transform _target;

    // Start is called before the first frame update
    void Start()
    {
        _target = Camera.main.transform;
    }

    // Update is called once per frame
    void Update()
    {

        _callout.transform.LookAt(_target, Vector3.up);
    }

    public void OnMouseOver()
    {
        _callout.SetActive(true);
    }

    public void OnMouseExit()
    {
        _callout.SetActive(false);
    }


}
