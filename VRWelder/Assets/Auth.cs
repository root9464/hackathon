using System;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Auth : MonoBehaviour
{
    public GameObject loadingPanel;
    public Slider progressBar;
    public TextMeshProUGUI progressText;
    public TMP_InputField mailInput;
    public TMP_InputField passwordInput;

    public void Login()
    {
        if (mailInput.text != "" && passwordInput.text != "")
        {
            Request("https://0435-176-28-64-201.ngrok-free.app/api/signin");
            StartCoroutine(LoadSceneAsync("Weld"));
        }
        else
        {
            Debug.Log("negri");
        }
    }
    public void Request(string url)
    {
            var user = new UserLogin
            {
                email = mailInput.text,
                password = passwordInput.text
            };
            try
            {
                var request = UnityWebRequest.Post(url, JsonUtility.ToJson(user), "application/json");
                request.SetRequestHeader("Accept", "application/json");
                request.SetRequestHeader("Content-Type", "application/json");
                request.SetRequestHeader("ngrok-skip-browser-warning", "69420");
                StartCoroutine(onResponse(request));
            }
            catch (Exception e) { Debug.Log("ERROR : " + e.Message); }
    }
    private IEnumerator onResponse(UnityWebRequest req)
    {
        yield return req.SendWebRequest();
        if (req.isNetworkError)
            Debug.Log("Network error has occured: " + req.GetResponseHeader(""));
        else
            Debug.Log("Success " + req.downloadHandler.text);
        byte[] results = req.downloadHandler.data;
        Debug.Log("Second Success");

    }
    IEnumerator LoadSceneAsync(string levelName)
    {
        loadingPanel.SetActive(true);
        float progress = 0f;
        AsyncOperation op = SceneManager.LoadSceneAsync(levelName);
        op.allowSceneActivation = false;

        while (progress <= 1f)
        {
            progressBar.value = progress;
            progressText.text = Mathf.Round(progress * 100f) + "%";
            progress += .01f;
            yield return new WaitForSeconds(.01f);
        }

        while (!op.isDone && progress >= 1f)
        {
            op.allowSceneActivation = true;
            yield return null;
        }
    }
}
