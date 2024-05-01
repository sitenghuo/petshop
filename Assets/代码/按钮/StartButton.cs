using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    // public GameObject changeEvent;
    // Start is called before the first frame update
    void Start()
    {
        //GameObject.DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnStartButtonClick()
    {
        StartCoroutine(Wait());
    }

    IEnumerator Wait()
    {
        StartAnim.startAnim.SetBool("FadeOut",true);
        StartAnim.startAnim.SetBool("FadeIn",false);
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        // yield return new WaitForSeconds(1f);
        // StartAnim.startAnim.SetBool("FadeOut",false);
        // StartAnim.startAnim.SetBool("FadeIn",true);
    }

}
