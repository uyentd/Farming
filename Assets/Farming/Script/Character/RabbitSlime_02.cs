using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RabbitSlime_02 : MoveCharacter
{
    //không cần update vì kế thừa movecharacter

    public override void Attack()
    {
        Debug.LogError(" Rabit Attack ");
        animator.SetTrigger("AnimAtk");
    }
}
