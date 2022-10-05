using UnityEngine;

public class TimeOfDay : MonoBehaviour
{
    [SerializeField] private Material _day;
    [SerializeField] private Material _sunset;
    [SerializeField] private Material _night;

    [SerializeField] private GameObject _sunlight;
    [SerializeField] private GameObject _sunsetlight;
    [SerializeField] private GameObject _moonlight;


    public void Day()
    {
        RenderSettings.skybox = _day;
        _sunlight.SetActive(true);
        _sunsetlight.SetActive(false);
        _moonlight.SetActive(false);
    }

    public void Sunset()
    {
        RenderSettings.skybox = _sunset;
        _sunlight.SetActive(false);
        _sunsetlight.SetActive(true);
        _moonlight.SetActive(false);
    }

    public void Night()
    {
        RenderSettings.skybox = _night;
        _sunlight.SetActive(false);
        _sunsetlight.SetActive(false);
        _moonlight.SetActive(true);
    }


}
