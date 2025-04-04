using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NPC : MonoBehaviour
{
    public GameObject dialoguePanel;
    public TextMeshProUGUI dialogueText;
    public string[] dialogue;
    private int index = 0;
    public GameObject contButton;

    public float wordSpeed = 0.05f; // Default value to avoid 0
    public bool playerIsClose;

 void Start()
{
    if (dialoguePanel != null)
    {
        dialoguePanel.SetActive(false);  // Ensure it's hidden at the start
    }

    if (dialogueText != null)
    {
        dialogueText.text = "";
    }
}

    void Update()
    {
        if (playerIsClose && Input.GetKeyDown(KeyCode.E))
        {
            if (dialoguePanel != null && !dialoguePanel.activeInHierarchy)
            {
                dialoguePanel.SetActive(true);
                StartCoroutine(Typing());
            }
            else if (dialoguePanel != null && dialogueText.text == dialogue[index])
            {
                NextLine();
            }
        }

        if (dialoguePanel != null && dialoguePanel.activeInHierarchy && Input.GetKeyDown(KeyCode.Q))
        {
            RemoveText();
        }

        if (dialoguePanel != null && dialoguePanel.activeInHierarchy && dialogueText.text == dialogue[index])
        {
            if (contButton != null)
            {
                contButton.SetActive(true);
            }
        }
    }

    public void RemoveText()
    {
        if (dialogueText != null)
        {
            dialogueText.text = "";
        }
        index = 0;

        if (dialoguePanel != null)
        {
            dialoguePanel.SetActive(false);
        }
    }

    IEnumerator Typing()
    {
        if (dialogue.Length == 0 || dialogueText == null) yield break; // Prevent errors if no dialogue

        dialogueText.text = ""; // Clear text before typing
        foreach (char letter in dialogue[index].ToCharArray())
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(wordSpeed);
        }
    }

    public void NextLine()
    {
        if (contButton != null)
        {
            contButton.SetActive(false);
        }

        if (index < dialogue.Length - 1)
        {
            index++;
            if (dialogueText != null)
            {
                dialogueText.text = "";  // Clear text before typing new line
            }
            StartCoroutine(Typing());
        }
        else
        {
            RemoveText();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Paddle"))  // Make sure Player tag is correct
        {
            playerIsClose = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Paddle"))
        {
            playerIsClose = false;

            // Only hide if the panel exists and is active
            if (dialoguePanel != null && dialoguePanel.activeInHierarchy)
            {
                dialoguePanel.SetActive(false);
            }
        }
    }
}
