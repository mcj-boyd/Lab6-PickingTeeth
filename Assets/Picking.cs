using UnityEngine;
using System.Collections;

public class Picking : MonoBehaviour {

    public Camera pickingCamera;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if(Input.GetMouseButtonDown(0) == true)
        {
            //Creates a ray that is cst from the mouses position out into the world
            Vector3 mousePosition = Input.mousePosition;
            Ray pickingRay = pickingCamera.ScreenPointToRay(mousePosition);

            // Use the ray to see if any object collides with the ray
            RaycastHit hit;
            bool success = Physics.Raycast(pickingRay, out hit);
            if (success)
            {
                Debug.Log("THE NAME OF THE PICKED OBJECT IS:" + hit.collider.gameObject);

                //if the tag of the picked object is "Tooth
                if(hit.collider.gameObject.tag == "Tooth")
                {
                    //Destroy Tooth
                    Destroy(hit.collider.gameObject);
                }
            }
        }
	}
}
