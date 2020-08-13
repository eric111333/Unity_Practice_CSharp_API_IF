using UnityEngine;

public class walk : MonoBehaviour
{
    public float speed = 5;
    private Rigidbody rig;
    private CapsuleCollider cap;
    private Animator ani;
    void Start()
    {
        ani = GetComponent<Animator>();
    }
    private void Moves()
    {
        bool S = Input.GetKey(KeyCode.S);

        if (S)
        {
            ani.SetBool("走路開關", true);
            transform.Translate(0, 0, speed * -Time.deltaTime);

        }
        //else ani.SetBool("走路開關", false);       

    }
    private void Movew()
    {
        bool W = Input.GetKey(KeyCode.W);
        if (W)
        {
            ani.SetBool("走路開關", true);
            transform.Translate(0, 0, speed * Time.deltaTime);

        }
        else ani.SetBool("走路開關", false);
        bool A = Input.GetKey(KeyCode.A);
        if (A)
        {
            transform.Rotate(0, speed * -Time.deltaTime * 22, 0);

        }
        bool D = Input.GetKey(KeyCode.D);
        if (D)
        {
            transform.Rotate(0, speed * Time.deltaTime * 22, 0);

        }




    }
    private void FixedUpdate()
    {
        Moves();
    }

    void Update()
    {

        Movew();
    }
}
