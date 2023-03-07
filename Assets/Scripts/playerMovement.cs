using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class playerMovement : MonoBehaviour
{
    public TMP_Text scoreText;
    public TMP_Text timeText;
    int score = 0;

    float time = 10;

    public GameObject gameOverText;
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = score.ToString();
    }

    

    // Update is called once per frame
    void Update()
    {
        if(time >= 0)
        {
            Vector3 newPos = transform.position;

            if(Input.GetKey(KeyCode.W)){
                newPos.z = newPos.z + 10 * Time.deltaTime;
            }
            if(Input.GetKey(KeyCode.S)){
                newPos.z = newPos.z - 10 * Time.deltaTime;
            }
            if(Input.GetKey(KeyCode.A)){
                newPos.x = newPos.x - 10 * Time.deltaTime;
            }
            if(Input.GetKey(KeyCode.D)){
                newPos.x = newPos.x + 10 * Time.deltaTime;
            }

            transform.position = newPos;

            time -= Time.deltaTime;
            int timeInt = Mathf.RoundToInt(time);
            timeText.text = timeInt.ToString();
            gameOverText.SetActive(false);
        }
        else
        {
            gameOverText.SetActive(true);
        }
    

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Collect")
        {
            score++;
            scoreText.text = score.ToString();
            Destroy(other.gameObject);
        }
    }
}
