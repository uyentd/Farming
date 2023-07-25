using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleOOP : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Animal animal=new Animal();
        Animal animal1 = new Animal(2);

        Dog dog = new Dog();
        dog.number_legs = 4;
        dog.weight = 2;
        dog.Move();
        dog.speed = 4;

        Chicken chicken = new Chicken();
        chicken.number_legs = 2;
        chicken.weight = 3;
        chicken.Move();

        Bird bird = new Bird();
        bird.Move();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
//
public class Animal
{
    public int number_legs;
    public float weight;
    private string ADN;
    protected string color;
    public Animal()
    {

    }
    public Animal(int num_leg)
    {
        this.number_legs = num_leg;
        ADN = "Hexa";
    }
    public virtual void Move()
    {
        Debug.LogError(" Animal Move ");
    }
}
//1. ke thua
//2. dong goi
//3. truu tuong
//4. da hinh

public class Dog: Animal
{
    public int speed = 2;
    private void Jump()
    {
        Debug.LogError(" Dog jump  " );

    }
    public override void Move()
    {
        base.Move();
        Debug.LogError(" Dog move with : " + number_legs);
        Jump();
    }
}
public class Chicken : Animal
{
    public override void Move()
    {
        Debug.LogError(" Chicken walk: " + number_legs);
    }
}
public class Bird:Animal
{
    public override void Move()
    {
        Debug.LogError("Bird Fly");
    }
}
public class ChiHuaHua:Dog
{
    public void Bake()
    {
        color = "Brown";
        
    }
}