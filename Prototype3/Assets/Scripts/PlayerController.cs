using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    private Animator playerAnim;
    private AudioSource playerAudio;

    public float jumpForce;
    public float gravityModifier;
    public bool isGrounded;
    public bool gameOver;
    public ParticleSystem explosionParticle;
    public ParticleSystem dirtParticle;
    public AudioClip jumpSound;
    public AudioClip crashSound;
    private void Awake()
    {
        playerRb = GetComponent<Rigidbody>();
        playerAnim = GetComponent<Animator>();
        Physics.gravity *= gravityModifier;
        playerAudio = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (Input.GetButtonDown("Jump") && isGrounded && !gameOver)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false;
            playerAudio.PlayOneShot(jumpSound, 1.0f);
            playerAnim.SetTrigger("Jump_trig");
            dirtParticle.Stop();
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
            dirtParticle.Play();
        } else if (other.gameObject.CompareTag("Obstacle"))
        {
            dirtParticle.Stop();
            gameOver = true;
            Debug.Log("Game Over");
            playerAnim.SetBool("Death_b", true);
            playerAnim.SetInteger("DeathType_int", 1);
            playerAudio.PlayOneShot(crashSound, 1.0f);
            explosionParticle.Play();
        }
    }
}
