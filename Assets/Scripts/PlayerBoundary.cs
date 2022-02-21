using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBoundary : MonoBehaviour
{
    public GameObject Player;
    public float horizontalBoundary = 10.0f;
    public float verticalBoundary = 6.0f;
    public float yPosition = 0.5f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Player.transform.position.x <= -horizontalBoundary)
        {
            Player.transform.position = new Vector3(-horizontalBoundary,yPosition, transform.position.z);
        }

        if (Player.transform.position.x >= horizontalBoundary)
        {
            Player.transform.position = new Vector3(horizontalBoundary, yPosition, transform.position.z);
        }

        if (Player.transform.position.z <= -verticalBoundary)
        {
            Player.transform.position = new Vector3(transform.position.x, yPosition, -verticalBoundary);
        }

        if (Player.transform.position.z >= verticalBoundary)
        {
            Player.transform.position = new Vector3(transform.position.x, yPosition, verticalBoundary);
        }
    }
}
