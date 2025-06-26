using UnityEngine;

public class oncollison : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);
        //you can get name, transform value, tag and is active that returns boolean value
    }

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log(collision.gameObject.transform);
    }


}
