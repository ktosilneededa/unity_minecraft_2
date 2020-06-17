using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShrekController : MonoBehaviour
{
    public GameObject Explosion;
    public GameObject player;
    public Material spookyMaterial;
    public bool metPlayer;
    public float JumpForce = 200;

    GameObject[] voxels;
    GameObject voxelToDestroy;

    private AudioSource audiosource;

    private new Rigidbody rigidbody;
    private float jumpDelay;


    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        metPlayer = false;
        audiosource = GetComponent<AudioSource>();
    }

    void Update()
    {
        var v = player.transform.position - new Vector3(transform.position.x, player.transform.position.y, transform.position.z);
        transform.rotation = Quaternion.LookRotation(v);

        var nv = v.normalized;
        rigidbody.velocity = new Vector3(nv.x, rigidbody.velocity.y, nv.z);

        var ray = new Ray(transform.position + Vector3.down * 0.95f, player.transform.position - transform.position);
        if (Physics.Raycast(ray, out var hit, 1f)) 
        {
            if (hit.collider != null)
            {
                Jump();
            }
        }

        jumpDelay -= Time.deltaTime;
    }

    private void Jump()
    {
        if (jumpDelay <= 0)
        {
            rigidbody.AddForce(Vector3.up * JumpForce);
            jumpDelay = 0.5f;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            metPlayer = true;

            StartCoroutine(SelfTerminate());

        }
    }

    void DeleteVoxels() {
        
        voxels = GameObject.FindGameObjectsWithTag("Voxel");
        foreach (GameObject v in voxels)
        {
            float dist = Vector3.Distance(transform.position, v.transform.position);
            float dist2 = Vector3.Distance(transform.position, player.transform.position) - 0.5f;
            if (dist < 4)
            {
                Destroy(v);
            } 
        }
    }

    void Explode()
    {
        GameObject explosion = Instantiate(Explosion, transform.position, Quaternion.identity);

        Destroy(gameObject, 0.25f);
        Destroy(explosion, 1.5f);
    }

    void GetSpooky()
    {
        GetComponent<MeshRenderer>().material = spookyMaterial;
;
    }

    void HitPlayer()
    {
        var playerHealth = player.GetComponent<PlayerHealth>();
        playerHealth.TakeDamage(1);
    }

    IEnumerator SelfTerminate()
    {
        audiosource.PlayOneShot(audiosource.clip, 25f);
        yield return new WaitForSeconds(1);
        GetSpooky();
        DeleteVoxels();
        Explode();
        HitPlayer();
    }
}
