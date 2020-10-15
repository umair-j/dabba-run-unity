using UnityEngine;

public class movement : MonoBehaviour
{

    
    public Rigidbody rb;
    public float forwardForce = 1000f;
    public float sideForce = 250f;
    
private float ScreenWidth;

    // Start is called before the first frame update
void Start()
	{
		ScreenWidth = Screen.width;

	}
    void Update()
	{
		int i = 0;
		//loop over every touch found
		while (i < Input.touchCount)
		{
			if (Input.GetTouch(i).position.x > ScreenWidth / 2)
			{
				//move right
                rb.AddForce(0,0,-(sideForce*Time.deltaTime),ForceMode.VelocityChange);
				
			}
			if (Input.GetTouch(i).position.x < ScreenWidth / 2)
			{
				//move left
                

                rb.AddForce(0,0,sideForce*Time.deltaTime,ForceMode.VelocityChange);
			}
			++i;
		}
        
	}

    

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(forwardForce*Time.deltaTime,0,0);
        
        if(Input.GetKey("a")){
            rb.AddForce(0,0,sideForce*Time.deltaTime,ForceMode.VelocityChange);
        }
        if(Input.GetKey("d")){
            rb.AddForce(0,0,-(sideForce*Time.deltaTime),ForceMode.VelocityChange);
        }
        if(rb.position.y<-1f){
            FindObjectOfType<gameManager>().endGame();
        }        

    }
    

}
