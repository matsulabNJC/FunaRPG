using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CardController : MonoBehaviour
{
    private Vector3 screenPoint;
    private Vector3 offset;
    public float speed;
    public int n;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        float moveY = Input.GetAxis("Vertical") * Time.deltaTime * speed;

        transform.position = new Vector2(
            Mathf.Clamp(transform.position.x + moveX, -9.55f, 9.55f),
            Mathf.Clamp(transform.position.y + moveY, -3.9f, 3.9f)
            );
    }
    void OnMouseDown()
    {
        this.screenPoint = Camera.main.WorldToScreenPoint(transform.position);
        this.offset = transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
    }

    void OnMouseDrag()
    {
        Vector3 currentScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
        Vector3 currentPosition = Camera.main.ScreenToWorldPoint(currentScreenPoint) + this.offset;
        transform.position = currentPosition;
    }

    void OnTriggerStay2D(Collider2D other)
    {
        n = 1;
        Debug.Log("ƒ^ƒbƒ`");
    }
    void OnTriggerExit2D(Collider2D other)
    {
        n = 2;
        Debug.Log("—£‚ê‚½");
    }
}
