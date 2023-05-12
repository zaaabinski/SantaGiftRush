using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

public class GenerateTerrain : MonoBehaviour
{
    public SpriteShapeController shape;
    public int scale = 100;
    public int nrOfPoints = 100;

    public void Start()
    {
        shape = GetComponent<SpriteShapeController>();
        float distBtwPoints = (float)scale / (float)nrOfPoints;
        shape.spline.SetPosition(index: 2, shape.spline.GetPosition(index: 2) + Vector3.right * scale);
        shape.spline.SetPosition(index: 3, shape.spline.GetPosition(index: 3) + Vector3.right * scale);

        for (int i = 0; i < nrOfPoints; i++)
        {
            float xPos = shape.spline.GetPosition(index: i + 1).x + distBtwPoints;
            shape.spline.InsertPointAt(index: i + 2, point: new Vector3(xPos, 6 * Mathf.PerlinNoise(i * Random.Range(1.5f, 8.0f), 0)));
        }

        for (int i = 2; i < nrOfPoints + 2; i++)
        {
            shape.spline.SetTangentMode(i, ShapeTangentMode.Continuous);
            shape.spline.SetLeftTangent(i, new Vector3(-3.5f, 0, 0));
            shape.spline.SetRightTangent(i, new Vector3(3.5f, 0, 0));
        }

    }
}
