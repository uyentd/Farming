using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QueenSlime_03 : MoveCharacter
{
    //không cần update vì kế thừa movecharacter

    public override void Attack()
    {
        Debug.LogError(" Queen Attack ");
        animator.SetTrigger("AnimAtk");
    }
}
