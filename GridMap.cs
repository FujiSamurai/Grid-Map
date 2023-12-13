using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridMap : MonoBehaviour
{
    [SerializeField] private GameObject prefab;

    private int rightPosX = -3;
    private int rightPosY = 0;
    private int leftPosX = 3;
    private int leftPosY = 0;

    private void Start()
    {
        Quaternion rotationForCubeRight = Quaternion.Euler(0f, 0f, 45f);
        Quaternion rotationForCubeLeft = Quaternion.Euler(0f, 0f, 30f);

        GameObject cubeRight = Instantiate(prefab, new Vector3(rightPosX, rightPosY), rotationForCubeRight);

        GameObject cubeLeft = Instantiate(prefab, new Vector3(leftPosX, leftPosY), rotationForCubeLeft);

        cubeRight.transform.localScale = new Vector3(3, 3, 3);
        cubeLeft.transform.localScale = new Vector3(2, 2, 2);
    }
}
