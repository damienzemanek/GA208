using System;
using Sirenix.OdinInspector;
using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{
    [ShowInInspector, ReadOnly] Vector2 moveDir;
    [ShowInInspector, ReadOnly] bool isMoving = false;
    [ShowInInspector, ReadOnly] int currentSeeds;
    [ShowInInspector, ReadOnly] int plantedSeeds = 0;
    [Required] public GameObject seedPrefab;
    [Required] public TextMeshProUGUI txt_remainingSeedsNum;
    [Required] public TextMeshProUGUI txt_plantedSeedsNum;
    public int maxSeeds = 5;
    public float speed = 0.012f;


    void OnEnable()
    {
        currentSeeds = maxSeeds;
        UpdateUI();
    }

    void FixedUpdate()
    {
        if(!isMoving) return;
        transform.Translate(moveDir * speed);
    }

    void Update()
    {
        PollMove();
        PollSpawnSeed();
    }
    
    
    void PollSpawnSeed()
    {
        if (!Input.GetKeyDown(KeyCode.Space)) return;
        if (currentSeeds <= 0) return;
        currentSeeds--;
        plantedSeeds++;
        Instantiate(seedPrefab, transform.position, Quaternion.identity);
        UpdateUI();
    }

    void PollMove()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            isMoving = true;
            moveDir = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        }
        else 
            isMoving = false;
    }

    void UpdateUI()
    {
        txt_remainingSeedsNum.text = currentSeeds.ToString();
        txt_plantedSeedsNum.text = plantedSeeds.ToString();
    }
}
