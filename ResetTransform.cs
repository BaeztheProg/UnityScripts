using UnityEngine;

public class ResetTransform : MonoBehaviour
{
    Vector3 startLocation;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startLocation = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(KeyCode.Space)){
            print("Space was pressed");
            transform.position = startLocation;
            print(transform.position.y);
            print(startLocation.y);
        }
    }
}
