using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rBody;
    public GroundSensor sensor;
    public SpriteRenderer render;
    public Animator anim;
    AudioSource source;
    public AudioClip deathSound;

    public Vector3 newPosition = new Vector3(50, 5, 0);

    public float movementSpeed = 5;
    public float jumpForce = 10;
    private float inputHorizontal;

    public bool jump = false;

    public AudioClip jumpSound;

    public Transform bulletSpawn;
    public GameObject bulletPrefab;

    private bool canShoot = true;
    public float timer;
    public float rateOfFire = 1;

    public Transform hitBox;
    public float hitBoxRadius = 2;

    public bool isDeath = false;

    public Animator animator;

    public GameObject balaPrefab;
    public Transform balaSpawn;
    

    void Awake()
    {
        rBody = GetComponent<Rigidbody2D>();
        render = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
        source = GetComponent<AudioSource>();

        animator = GetComponent<Animator>();
    }

    // Start is called before the first frame update
    void Start()
    {
        //Teletransporta al personaje a la posicion de la variable newPosition
        //transform.position = newPosition
    }

    // Update is called once per frame
    void Update()
    {
        inputHorizontal = Input.GetAxis("Horizontal");

        //transform.position = transform.position + new Vector3(1, 0, 0) * movementSpeed * Time.deltaTime;
        //transform.position += new Vector3(inputHorizontal, 0, 0) * movementSpeed * Time.deltaTime;

        /*if(jump == true)
        {
           Debug.Log("estoy saltando"); 
        }
        else if(jump == false)
        {
            Debug.Log("estoy en el suelo");
        }
        else
        {
            Debug.Log("afsdg");
        }*/

        
        
        Movement();

        Jump();

        //Shoot();

        if(Input.GetButtonDown("Fire1"))
        {
            Instantiate(balaPrefab, balaSpawn.position, balaSpawn.rotation);
        }

        if(Input.GetKeyDown(KeyCode.J))
        {
            //Attack();
            anim.SetTrigger("isAttacking");
            Instantiate(balaPrefab, balaSpawn.position, balaSpawn.rotation);
        }

    }

    void FixedUpdate()
    {
        rBody.velocity = new Vector2(inputHorizontal * movementSpeed, rBody.velocity.y);
    }

    void Jump()
    {
        if(Input.GetButtonDown("Jump") && sensor.isGrounded == true)
        {
            rBody.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            //anim.SetBool("IsJumping", true);
            source.PlayOneShot(jumpSound);


            animator.SetBool("IsJumping", true);
        }
    }
    
    void Movement()
    {
        /*if(inputHorizontal < 0)
        {
            //render.flipX = true;
            transform.rotation = Quaternion.Euler(0, 180, 0);
            anim.SetBool("IsRunning", true);
        }
        else if(inputHorizontal > 0)
        {
            //render.flipX = false;
            transform.rotation = Quaternion.Euler(0, 0, 0);
            anim.SetBool("IsRunning", true);
        }
        else
        {
            anim.SetBool("IsRunning", false);
        }*/

        if(inputHorizontal < 0)
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
            animator.SetBool("IsRunning", true);
        }
        else if(inputHorizontal > 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
            animator.SetBool("IsRunning", true);
        }
        else
        {
            animator.SetBool("IsRunning", false);
        }
    }

    void Shoot()
    {
        if(!canShoot)
        {
            timer += Time.deltaTime;

            if(timer >= rateOfFire)
            {
                canShoot = true;
                timer = 0;
            }
        }

        if(Input.GetKeyDown(KeyCode.F) && canShoot)
        {
            Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);

            canShoot = false;
        }
    }

    public void Attack()
    {
        Collider2D[] enemies = Physics2D.OverlapCircleAll(hitBox.position, hitBoxRadius);

        foreach (Collider2D enemy in enemies)
        {
            if(enemy.gameObject.tag == "Goombas")
            {
                //Destroy(enemy.gameObject);
                Enemy enemyScript = enemy.GetComponent<Enemy>();

                enemyScript.GoombaDeath();
            }
        }
    }

    public void Death()
    {
        source.PlayOneShot(deathSound);

        SceneManager.LoadScene(0);

        //StartCoroutine("Die");
        //StartCoroutine(Die(7, 8.5f));

        //StopCoroutine("Die");
        //StopAllCoroutines();
    }

    public IEnumerator Die()
    {
        isDeath = true;

        source.PlayOneShot(deathSound);

        //Time.timeScale = 0;

        yield return new WaitForSeconds(3);
        //yield return new WaitForSecondsRealtime(2);
        //yield return null;
        //yield return new WaitForEndOfFrame();

        //yield return Corrutina();

        SceneManager.LoadScene(0);
    }

    IEnumerator Corrutina()
    {
        yield return new WaitForSeconds(2);
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(hitBox.position, hitBoxRadius);
    }
}
