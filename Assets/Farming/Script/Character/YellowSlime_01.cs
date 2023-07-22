using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowSlime : MoveCharacter
{
    //không cần update vì kế thừa movecharacter

    public override void Attack()
    {
        Debug.LogError(" Yellow Attack ");
        animator.SetTrigger("AnimAtk");
    }
}
