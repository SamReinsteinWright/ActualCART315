using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;
public class SheepScript : MonoBehaviour
{
    public float yPos, xPos;
    private Rigidbody2D rb;
    [SerializeField]
    private float rotationspeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        StartCoroutine(Launch());

    }

    private void OnTriggerStay2D(Collider2D other)
    {
       
        if (other.gameObject.CompareTag("Sheep"))
        {
            var othervelx = other.gameObject.GetComponent<Rigidbody2D>().linearVelocity.x;
            var velx = rb.linearVelocity.x;
            var othervely = other.gameObject.GetComponent<Rigidbody2D>().linearVelocity.y;
            var vely = rb.linearVelocity.y;
            rb.AddForce(transform.right * (othervelx - velx)/20);
            rb.AddForce(transform.up * (othervely - vely)/20);
            //transform.LookAt(Input.mousePosition);
        }
    }

    // Update is called once per frame
    void Update()
    {
     
    }
    private IEnumerator Launch()
    {
        //choose random x and y dir
        rb.AddForce(transform.right * Random.Range(-10f, 10f));
        rb.AddForce(transform.up * Random.Range(-10f, 10f));
        // wait for X seconds
        yield return new WaitForSeconds(5);
        //apply force
        //  vert
        StartCoroutine(Launch());
    }
        
}
