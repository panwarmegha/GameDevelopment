using UnityEngine;

public class ontrigger : MonoBehaviour
{

  
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log(other.gameObject.transform);
    }

    // private void OnTriggerStay(Collider other)
    // {
    //     Debug.Log(other.gameObject.transform.position);
    // }
}
