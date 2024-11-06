using Unity.VisualScripting;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject gumball;
    Transform spawnLoc;
    float  timer;
    int prevNum = 0;
    bool spawnOnce = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timer = 0;
        spawnLoc = GetComponent<Transform>();

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime  ;
        
        
        if (Mathf.RoundToInt(timer) % 2 == 0 && spawnOnce){
            for (var i = 0; i < 10; i++)
            {
                GameObject clone = Instantiate(gumball, new Vector3(i * 2.0f, spawnLoc.position.y, spawnLoc.position.z), Quaternion.identity);
                Destroy(clone, 5);
            }
            prevNum = (int)timer;
            spawnOnce = false;
        }
        Debug.Log(prevNum);
        if (!spawnOnce && prevNum!=(int)timer){

            spawnOnce = true;
        }
        

    }
}
