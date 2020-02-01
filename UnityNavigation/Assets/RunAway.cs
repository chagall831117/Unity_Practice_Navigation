using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class RunAway : MonoBehaviour
{
    public Transform[] Locations;//隨機位置
    public NavMeshAgent Nav; //領航員
    public Animator Ani; //動畫控制器
    // Start is called before the first frame update
    void Start()
    {
        Ani = GetComponent<Animator>();
        Nav = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        RandomRun();
    }
    public void RandomRun()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Nav.SetDestination(Locations[Random.Range(0, Locations.Length)].position);
            Ani.SetBool("跑步開關", true);
            Invoke("RunAni", 3f);
        }
    }
    public void RunAni()
    {
        Ani.SetBool("跑步開關", false);
    }
}
