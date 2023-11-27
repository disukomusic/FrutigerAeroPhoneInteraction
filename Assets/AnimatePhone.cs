using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatePhone : MonoBehaviour
{
    public Animator phoneAnimator;
    public Animator screenAnimator;
    
    public void OpenPhone()
    {
        phoneAnimator.SetBool("NearPhone",true);
        screenAnimator.SetBool("NearPhone",true);

    }

    public void ClosePhone()
    {
        phoneAnimator.SetBool("NearPhone",false);
        screenAnimator.SetBool("NearPhone",false);

    }
}
