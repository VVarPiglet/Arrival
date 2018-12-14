using UnityEngine;
using UnityEngine.AI;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float moveStopRadius = 0.2f;

    CameraRaycaster cameraRaycaster;
    Vector3 currentClickTarget;
    public float movementSpeed = 10.0f;
    // public float hoverAmount = 3.5f;

    private void Start()
    {
        cameraRaycaster = Camera.main.GetComponent<CameraRaycaster>();
        currentClickTarget = transform.position;
    }

    // Fixed update is called in sync with physics
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            print(cameraRaycaster.layerHit);
            switch (cameraRaycaster.layerHit)
            {
                case Layer.Walkable:
                    currentClickTarget = cameraRaycaster.hit.point;
                    break;
            }
        }
        transform.position = Vector3.MoveTowards(transform.position, currentClickTarget, Time.deltaTime * movementSpeed);
    }
}

