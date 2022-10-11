using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwapCamera : MonoBehaviour
{
    [SerializeField] private Camera stereoscopicCamL;
    [SerializeField] private Camera stereoscopicCamR;
    [SerializeField] private Camera monoscopicCam;
    void Start()
    {
        stereoscopicCamL.enabled = false;
        stereoscopicCamR.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            monoscopicCam.enabled = !monoscopicCam.enabled;
            stereoscopicCamL.enabled = !stereoscopicCamL.enabled;
            stereoscopicCamR.enabled = !stereoscopicCamR.enabled;
        }
        
        if (Input.GetKeyDown(KeyCode.LeftBracket))
        {
            stereoscopicCamR.transform.position = new Vector3(stereoscopicCamR.transform.position.x, stereoscopicCamR.transform.position.y, stereoscopicCamR.transform.position.z + 0.01f);
        }
        if (Input.GetKeyDown(KeyCode.RightBracket))
        {
            stereoscopicCamR.transform.position = new Vector3(stereoscopicCamR.transform.position.x, stereoscopicCamR.transform.position.y, stereoscopicCamR.transform.position.z - 0.01f);

        }
    }
}
