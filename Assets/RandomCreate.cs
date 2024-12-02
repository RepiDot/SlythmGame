using UnityEngine;

public class RandomCreate : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //float randomX = Random.Range(0f, Screen.width);
        //float randomY = Random.Range(0f, Screen.height);

        for(int i=0; i<1; i++) {
            Instantiate(GameObject.Find("Circle"), new Vector3(0, 0, 0f), Quaternion.identity);
            Instantiate(GameObject.Find("Circle"), new Vector3(10, 10, 0f), Quaternion.identity);

        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
