using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance ;
    public MoveCharacter[] moveCharacters; // khai báo movecharacter là 1 mảng, mảng thì gồm có 3 phần tử
    public int index;// giá trị mặc định index = 0
    [HideInInspector]// ẩn cur_cc trên Inspector
    public MoveCharacter cur_cc;
    public CameraControl cameraControl;

    private void Awake()
    {
        instance = this ;
    }
    // Start is called before the first frame update
    void Start()
    {
        index = -1;// gán để nó nằm ngoài phần tử thấp nhất ( chưa hiểu lắm )
        ChangeCharacter();
    }

    // Update is called once per frame
    void Update()
    {
        //nhập Space từ bàn phím, nếu index = -1 thì không bật script movecharacter lên
        // nếu = 0 sẽ lấy số object gán lên GameManager
        if(Input.GetKeyDown(KeyCode.Space))
        {
            ChangeCharacter();
        }
    }
    public void ShowMess()// singleton của monobehavior
    {
        Debug.LogError("Movecharacter: " + moveCharacters.Length );
    }    
    private void ChangeCharacter()
    {

        index++; //index = index + 1
                 // mỗi lần space, index sẽ được + thêm 1 số, mỗi 1 số hiện tại (16/07) đang được gán với 1 GO character
        Debug.LogError("Index:" + index);
        if (index >= moveCharacters.Length)
        {
            index = 0;
        }
        //Tại 1 thời điểm chỉ điều khiển 1 object
        // Nếu cur_cc khác null,
        if (cur_cc != null)// cur_null thì chạy else
        {
            // cái nào đang bật thì tắt nó đi
            cur_cc.enabled = false;
        }
        else
        {

        }
        // thằng này luôn chạy theo index ++
        cur_cc = moveCharacters[index];
        cur_cc.enabled = true;
        cameraControl.ChangeTaget(cur_cc.trans); //hành động gọi hàm, truyền cho nó 1 transform mới của nhân vật mới. Dấu '.' là truy vấn tới
    }
}
