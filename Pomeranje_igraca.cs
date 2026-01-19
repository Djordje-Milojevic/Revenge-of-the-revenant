using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
public class Pomeranje_igraca : MonoBehaviour
{
    public int pokupljeno = 0;
    public int neprijatelj_h = 100;
    public Rigidbody rb;
    public float napredSila = 0;
    public float stranaSila = 0;
    public float groundCheckDistance = 1.5f;
    public LayerMask groundLayer;
    private Vector3 groundNormal = Vector3.up;
    private void FixedUpdate()
    {
        CheckGround();
        Vector3 input = Vector3.zero;
        if (Keyboard.current.aKey.isPressed) input.x += 1; //x za levo desno
        if (Keyboard.current.dKey.isPressed) input.x -= 1;
        if (Keyboard.current.wKey.isPressed) input.z -= 1; //z za napred nazad
        if (Keyboard.current.sKey.isPressed) input.z += 1;
        input = input.normalized; // po dijagonali ide isto
        Vector3 sila = new Vector3(
            input.x * stranaSila, 0, input.z * napredSila
        );
        Vector3 prilagodjenaSila = Vector3.ProjectOnPlane(sila, groundNormal);
            rb.linearVelocity = new Vector3
            (
            prilagodjenaSila.x,
            rb.linearVelocity.y,
            prilagodjenaSila.z
            );
    }
    void CheckGround()
    {
        Ray ray = new Ray(transform.position, Vector3.down); //laser koji gleda na pod
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, groundCheckDistance, groundLayer))
        {
            groundNormal = hit.normal;
        }
        else
        {
            groundNormal = Vector3.up;
        }
    }
    if(other.gameObject.CompareTag("Neprijatelj")) //tag za neprijatelja ako je pronadjen onda skor ide ka gore
    {
        pokupljeno++;
    }

    if (neprijatelj_h < 1)
    {
        other.gameObject.SetActive(false);  // nestaje igrac ako mu helt bude ispod 1 to jest 0
    }

    if(pokupljeno > br_neprijatelja)
    {
        void OnTriggerEnter (Collider other) 
        {
            if (other.gameObject.CompareTag("PickUp")) //samo tag da se stavi na prolaz i da se promeni sa PickUp-opm
                { 
                    SceneManager.LoadSceneAsync(3);
                }
        }
    }
}

