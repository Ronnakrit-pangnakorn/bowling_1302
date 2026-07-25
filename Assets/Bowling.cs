using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Bowling : MonoBehaviour
{
    [SerializeField]
    private Rigidbody rb;

    [SerializeField]
    private int forcepower;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
            Shootball();

        if (Keyboard.current.rightArrowKey.isPressed)
            Moveright();
        if (Keyboard.current.leftArrowKey.isPressed)
            Moveleft();


    }
    private void Shootball()
    {
        rb.AddForce(Vector3.forward * forcepower, ForceMode.Impulse);
    }
    private void Moveright()
    {
        transform.position += new Vector3(1f, 0f, 0f) * Time.deltaTime;
    }
    private void Moveleft()
    {
        transform.position += new Vector3(-1f, 0f, 0f) * Time.deltaTime;
    }
}
