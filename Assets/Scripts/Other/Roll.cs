using UnityEngine;

public class Roll : MonoBehaviour
{
    
    public float horizontalSpeed = 2.0f;
    public float verticalSpeed = 2.0f;

    float x_wanted_roll, x_current_roll, y_roll_delta;

    Transform posirol;

    bool steering;

    void Start()
    {
        posirol = GetComponent<Transform>();
        steering = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!steering && Input.GetMouseButtonDown(0))
        {
            steering = true;
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }

        if (steering && Input.GetKeyDown(KeyCode.Escape))
        {
            steering = false;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }

        if (!steering) return;

        y_roll_delta = horizontalSpeed * Input.GetAxis("Mouse X");
        x_wanted_roll = (x_wanted_roll <= 90) ? ((x_wanted_roll >= -90) ? x_wanted_roll + verticalSpeed * Input.GetAxis("Mouse Y") : -90) : 90;

        transform.Rotate(x_current_roll - x_wanted_roll, 0, 0, Space.Self);
        x_current_roll = x_wanted_roll;
        transform.Rotate(0, y_roll_delta, 0, Space.World);
    }
}
