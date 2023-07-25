using Unity.VisualScripting;
using UnityEngine;

public class MoveCharacter : MonoBehaviour
{
    //tạo var
    public float speed = 2f;
    public Transform trans;
    public Animator animator;

    private void Awake()
    {
        Debug.LogError("Awake");
        this.enabled = false;
        // this: chỉ MoveCharacter
        // để cho những GO có gắn scrip MoveCharacter khi play đều tắt đi
       


    }

    private void OnEnable()
    {
        Debug.LogError("OnEnable");
    }
    // Start is called before the first frame update
    void Start()
    {
        trans = GetComponent<Transform>();
       // animator.SetFloat("Speed", 1);
    }

    public virtual void Attack()
    {

    }    

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Vector3 pos_new = new Vector3(x, 0, z);
        trans.forward = pos_new;
        float length = pos_new.magnitude;
        if (length>0 )
        {
           
            trans.position = trans.position + pos_new * speed * Time.deltaTime;
            animator.SetFloat("Speed", 1); 
        }
        else
        {
            //trans.forward = pos_new;
           // trans.position = trans.position + pos_new * speed * Time.deltaTime;
            animator.SetFloat("Speed", 0);
        }
        if ( Input.GetKeyDown(KeyCode.E) ) // Nhập E từ bàn phím sẽ kích hoạt Attack
        {
            Attack();
        }

        // lấy vị trí mới từ pos_new
        // Time.deltaTime là một thuộc tính dùng để tính toán thời gian giữa hai khung hình liên tiếp
        // tường được sử dụng để cập nhật trong các move object = cách nhân V hoặc a với Tome.deltaTime để đảm bảo sẽ tự chia FPS cho các dòng máy khác nhau
    }

   
    private void OnDisable()
    {
        animator.SetFloat("Speed", 0);
    }
    // check xem nó đụng thằng nào
    // để cái collision này chạy thì phải tick kinematic trong Inspector
    private void OnCollisionEnter(Collision collision)
    {
        // log cái thằng đụng vào
        Debug.LogError("enter: " + collision.gameObject.name);
    }
    public void OnCollisionExit(Collision collision)
    {
        // log cái thằng đụng vào
        Debug.LogError("Exit: " + collision.gameObject.name);
    }
    public void OnCollisionStay(Collision collision)
    {
        // log cái thằng đụng vào
        Debug.LogError("stay: " + collision.gameObject.name);
    }

    // để thằng này chạy thì phải tick Is Trigger trong Inspector
    public void OnTriggerEnter(Collider other)
    {
     //   Debug.LogError("OnTriggerEnter :");

    }
    public void OnTriggerExit(Collider other)
    {
     //   Debug.LogError("OnTriggerExit :");
    }
    public void OnTriggerStay(Collider other)
    {
   //     Debug.LogError("OnTriggerStay :");
    }
}
