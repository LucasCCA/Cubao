using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    void Start()
    {
        rb.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    // FixedUpdate � melhor pra mexer com f�sica
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
