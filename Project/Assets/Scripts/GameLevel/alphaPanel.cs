using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class alphaPanel : MonoBehaviour
{
    public GameObject alpha;
    // Start is called before the first frame update
    void Start()
    {
        alpha.GetComponent<CanvasGroup>().DOFade(0, 2f);
    }

    
}
