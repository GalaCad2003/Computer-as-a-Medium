using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMana : MonoBehaviour
{
    public Animator animator;
    public int Mana = 100;
    public TMP_Text manaText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        manaText.text = "Mana: " + Mana;
    }

    // Update is called once per frame
    void Update()
    {
        manaText.text = "Mana: " + Mana;
        MAttack();
    }
    void MAttack()
    {
        if (Keyboard.current.rKey.wasPressedThisFrame)
        {
            animator.SetBool("Magic", true);
            Mana -= 10;
        }
        else
        {
            animator.SetBool("Magic", false);
        }
    }



}
