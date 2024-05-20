using System.Collections.Generic;
using UnityEngine;

public class SwapCubes : MonoBehaviour
{
    private List<GameObject> selectedCubes = new List<GameObject>();
    private int layerMask;

    void Start()
    {
        // "Cubes" adýnda bir layer oluþturun ve kutularýnýzý bu layer'a atayýn.
        layerMask = LayerMask.GetMask("Cubes");
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, Mathf.Infinity, layerMask))
            {
                if (hit.collider != null)
                {
                    GameObject selectedCube = hit.collider.gameObject;
                    if (!selectedCubes.Contains(selectedCube))
                    {
                        selectedCubes.Add(selectedCube);
                    }

                    if (selectedCubes.Count == 2)
                    {
                        SwapPositions(selectedCubes[0], selectedCubes[1]);
                        selectedCubes.Clear();
                    }
                }
            }
        }
    }

    void SwapPositions(GameObject cube1, GameObject cube2)
    {
        Vector3 tempPosition = cube1.transform.position;
        cube1.transform.position = cube2.transform.position;
        cube2.transform.position = tempPosition;
    }
}
