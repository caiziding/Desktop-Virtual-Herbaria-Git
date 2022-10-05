using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] private GameObject[] prefabs; //Prefabs to spawn

    private Camera c;
    private int selectedPrefab = 0;
    private int rayDistance = 300;


    void Start()
    {
        c = GetComponent<Camera>();
        if (prefabs.Length == 0)
        {
            Debug.LogError("You haven't assigned any Prefabs to spawn");
        }
    }

    void Update()
    {
        selectedPrefab = Random.Range(0, prefabs.Length);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3[] spawnData = GetClickPositionAndNormal();
            if (spawnData[0] != Vector3.zero)
            {
                GameObject go = Instantiate(prefabs[selectedPrefab], spawnData[0], Quaternion.FromToRotation(prefabs[selectedPrefab].transform.up, spawnData[1]));
                go.name += " _instantiated";
            }
        }
    }

    Vector3[] GetClickPositionAndNormal()
    {
        Vector3[] returnData = new Vector3[] { Vector3.zero, Vector3.zero }; //0 = spawn poisiton, 1 = surface normal
        Ray ray = c.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit = new RaycastHit();
        if (Physics.Raycast(ray, out hit, rayDistance))
        {
            returnData[0] = hit.point;
            returnData[1] = hit.normal;
        }

        return returnData;
    }

}