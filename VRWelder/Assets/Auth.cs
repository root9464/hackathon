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

    public void Login()
    {
        Request("https://openvk.uk/method/Ovk.version");
        StartCoroutine(LoadSceneAsync("Weld"));
    }
    public void Request(string url)
    {
        try
        {
            var request = UnityWebRequest.PostWwwForm(url, "");
            request.SetRequestHeader("Content-Type", "application/json");
            request.SetRequestHeader("ngrok-skip-browser-warning", "0");
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
        // Some code after success

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
