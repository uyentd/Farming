using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleOOP : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Animal animal = new Animal(); // xin cấp phép vùng nhớ ( key: new), không đưa ra Inspector thì mới dùng "new"
        Animal animal1 = new Animal(2);
        Dog dog = new Dog(); // khai báo class Dog
        dog.number_legs = 4; // khai báo chó = 4 chân
        dog.weight = 2; // khai báo cân nặng chó = 2 kg
        dog.Move();
        dog.Speed = 1;

        Chicken chicken = new Chicken(); // khai báo class chicken
        chicken.number_legs = 2; // khai báo gà = 2 chân
        chicken.weight = 3;// khai báo gà nặng 3 kg
        chicken.Move();

        Bird bird = new Bird();
        bird.Move();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

public class Animal // 1 kiểu dữ liệu, khai báo class
{
    public int number_legs; // khai báo chân thú // funtion
    public float weight; // khai báo cân nặng
    private string ADN; // khai báo biến ADN, không cho các class khác kế thừa
    protected string color; // protected: chỉ những class kế thừa từ this.class mới truy cập được
    public Animal()
    {
        
    }
    public Animal ( int num_leg)// hàm khởi dựng có tham số
    {
        this.number_legs = num_leg;// this: đang chỉ chính class 
    }
    public virtual void Move () // var ( biến)
    {
        Debug.LogError("Move");
    }
}

// 1. kế thừa
// 2. đóng gói: những cái gì có thể xử lý bên trong class thôi, bên ngoaiuf ko động tới
// 3. trừu tượng
// 4. đa hình: thằng cha tạo funtion, rồi thằng con định nghĩa funtion đó phù hợp với chính nó

public class Dog : Animal
{
    public int Speed;
    private void Jump()
    {
        color = "Black";
        Debug.LogError ("Dog Jump");
    }
    public override void Move()
    {
        base.Move();  // để cho thằng cha cùng chạy
        Debug.LogError("Dog Move with 4 leg");
    }
    
}
public class Chicken : Animal
{
    public override void Move()
    {
        base.Move();
        Debug.LogError(" Chicken move with 2 leg");
    }
}
public class Bird: Animal
{
    public override void Move()
    {
        base.Move();
        Debug.LogError("Bird fly");
    }
}
public class Chihuahua : Dog
{
    
}
