using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawingManager : MonoBehaviour
{
    [Header("Line Prefab")]
    public GameObject linesPrefab;
    Line activeLine;

    [Header("Line Renderer")]
    [SerializeField] private LineRenderer lineRenderer;

    [Header("Drawing Count")]
    [SerializeField] private int drawSlot = 3;
    [SerializeField] private int zeroSlot = -1;

    [Header("Third Party")]
    private Camera cam;
    private GameManager gameManager;


    void Start()
    {
        cam = Camera.main;
        gameManager = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(gameManager.isCanDraw == true)
        {
            if (drawSlot != zeroSlot)
            {
                Drawing();
            }

        }
    }

    public void Drawing()
    {
        //When pressing down the left mouse button
        if (Input.GetMouseButtonDown(0))
        {
            //The line will be created
            GameObject newLines = Instantiate(linesPrefab);
            activeLine = newLines.GetComponent<Line>(); //Continuous line
            drawSlot = drawSlot - 1;

        }

        //Done drawing that line and will not continue in the same game object
        if (Input.GetMouseButtonUp(0))
        {
            activeLine = null;
        }

        //Continue the line
        if (activeLine != null)
        {
            //Mouse position to the game world
            Vector2 mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
            activeLine.CreatingLine(mousePos);

            
        }
    }
}
