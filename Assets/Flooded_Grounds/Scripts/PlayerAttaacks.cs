using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttaacks : MonoBehaviour
{
    private Animator anim;
    public float attackStamina = 10.0f;
    [SerializeField] float maxAttackStamina = 10.0f;
    [SerializeField] float attackDrain = 2.0f;
    [SerializeField] float attackRefill = 1.0f;
    // Start is called before the first frame update
    void Start()
    {

        anim = GetComponent<Animator>();
        attackStamina = maxAttackStamina;

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Attack Stamina"+attackStamina);
        if (attackStamina < maxAttackStamina)
        {
            attackStamina += attackRefill * Time.deltaTime;
        }
        if (attackStamina <= 0.1)
        {
            attackStamina = 0.1f;
        }
        if (attackStamina > 3.0)
        {

            if (SaveScripts.haveKnife == true)
            {
                if (Input.GetKeyDown(KeyCode.Mouse0))
                {
                    anim.SetTrigger("KnifeLMB");
                    attackStamina -= attackDrain;
                }
            }
            if (SaveScripts.haveKnife == true)
            {
                if (Input.GetKeyDown(KeyCode.Mouse1))
                {
                    anim.SetTrigger("KnifeRMB");
                    attackStamina -= attackDrain;
                }
            }
            if (SaveScripts.haveBat == true)
            {
                if (Input.GetKeyDown(KeyCode.Mouse0))
                {
                    anim.SetTrigger("BatLMB");
                    attackStamina -= attackDrain;
                }
            }
            if (SaveScripts.haveBat == true)
            {
                if (Input.GetKeyDown(KeyCode.Mouse1))
                {
                    anim.SetTrigger("BatRMB");
                    attackStamina -= attackDrain;
                }
            }
            if (SaveScripts.haveAxe == true)
            {
                if (Input.GetKeyDown(KeyCode.Mouse0))
                {
                    anim.SetTrigger("AxeLMB");
                    attackStamina -= attackDrain;
                }
            }
            if (SaveScripts.haveAxe == true)
            {
                if (Input.GetKeyDown(KeyCode.Mouse1))
                {
                    anim.SetTrigger("AxeRMB");
                    attackStamina -= attackDrain;
                }
            }
        }
    }
}
