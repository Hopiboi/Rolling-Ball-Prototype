using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Line : MonoBehaviour
{
    [Header("Line")]
    [SerializeField] private LineRenderer lineRenderer;
    [SerializeField] private float minDistance = 0.1f;
    [SerializeField] private EdgeCollider2D edgeColls;

    //list of vector 2 to use in colliders
    private readonly List<Vector2> colliderList = new List<Vector2>();

    //List of Points
    List<Vector2> pointers;

    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
    }

    //Player movement or Mouse Movement
    public void CreatingLine(Vector2 position)
    {
        //When there is no points
        if (pointers == null)
        {
            //Create new array
            pointers = new List<Vector2>();
            SetPoint(position);

            return;
        }

        //New points will draw when it exceeds the minimun distance
        //The less minDistance are, the smoother the lines is
        if (Vector2.Distance(pointers.Last(), position) > minDistance)
        {
            SetPoint(position);

            //Collider Arrays
            colliderList.Add(position);
            edgeColls.points = colliderList.ToArray();
        }

    }

    //Array of points
    public void SetPoint(Vector2 point)
    {
        //Adding the point in Array
        pointers.Add(point);

        //Points we have and where are their position/indicating
        lineRenderer.positionCount = pointers.Count;

        //New position of the new point when it is drawing
        lineRenderer.SetPosition(pointers.Count - 1, point);
    }
}
