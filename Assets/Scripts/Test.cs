using UnityEngine;

public class Test : MonoBehaviour
{

    //Global variables
    public bool myBool = false;
    float maxSize =10f;
    float minSize = 0.2f;
    bool Sizing = false;


    //////////////////////////////////////////////////////////////////////////////////

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Rotate(new Vector3(0.0f, -2f, 0.0f));
        gameObject.transform.localScale = new Vector3(2f, 2f, 2f);

        if (/*Vector3 = maxSize || Vector3>maxSize*/ gameObject.transform.localScale.y > maxSize)
        {
            //gameObject.transform.localScale.y -= maxSize;
        }
        else
        {
            //gameObject.transform.localScale.y += minSize;
        }
        if (myBool)
        {
            Debug.Log("Hi");
        }

    }
}
