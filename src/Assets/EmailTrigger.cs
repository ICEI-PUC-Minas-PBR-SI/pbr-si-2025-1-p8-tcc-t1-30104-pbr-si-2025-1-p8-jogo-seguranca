using UnityEngine;

public class EmailTrigger : MonoBehaviour
{
    // Vai ser Gerado
    private Email email;

    [SerializeField]
    public float detectionRadius = 5f;

    [SerializeField]
    public float minGenerateNewEmail = 20f;

    [SerializeField]
    public float maxGenerateNewEmail = 40f;

    [SerializeField]
    private GameObject emailIndicator;
    [SerializeField]
    private GameObject pressToTalkIndicator;

    private EmailManager manager;


    private Email currentEmail;
    private bool isEmailReady = false;
    private bool playerHasOpenedEmail = true;
    private Animator emailAnimator;
    private bool playerInside = false;

    private void Start()
    {
        emailAnimator = GetComponent<Animator>();
        manager = GameObject.FindAnyObjectByType<EmailManager>();
        emailIndicator.SetActive(false);
        Invoke(nameof(GenerateRandomEmail), Random.Range(minGenerateNewEmail, maxGenerateNewEmail));

    }

    private void Update()
    {
        bool playerDetected = false;

        if (isEmailReady)
        {

            
            emailAnimator.SetBool("Calling",true);
            emailIndicator.SetActive(true);
            if (IsPlayerNearby())
            {
                playerDetected = true;
                if (!playerInside)
                {
                    playerInside = true;
                    pressToTalkIndicator.SetActive(true);
                }
                HandlePlayerInteraction();
            }




        }

        if (!playerDetected && playerInside)
        {
            pressToTalkIndicator.SetActive(false);
            playerInside = false;


        }


    }

    private bool IsPlayerNearby()
    {
        Collider[] hitColliders = Physics.OverlapSphere(transform.position, detectionRadius);
        foreach (Collider collider in hitColliders)
        {
            if (collider.CompareTag("Player"))
            {
                return true;
            }
        }
        return false;
    }
    private void HandlePlayerInteraction()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            ShowEmail();
        }
        else if (manager.GetEmailIsShow())
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                // Confirmar que o e-mail é um ataque
                CloseEmail(false); 

            }
            else if (Input.GetKeyDown(KeyCode.Q))
            {
                // Confirmar que o e-mail não é um ataque
                CloseEmail(true);
            }
        }
    }

    private void ShowEmail()
    {
        if (currentEmail == null) return;


        manager.StartShowEmail(currentEmail);
  

    }

    private void CloseEmail(bool playerPressToConfirmAttack)
    {

        manager.EndEmail(currentEmail.isValid == playerPressToConfirmAttack); 
         emailAnimator.SetBool("Calling", false);
        emailIndicator.SetActive(false);
        playerHasOpenedEmail = true;
        isEmailReady = false;
        Invoke(nameof(GenerateRandomEmail), Random.Range(minGenerateNewEmail, maxGenerateNewEmail));
    }

    private void GenerateRandomEmail()
    {
        if (!playerHasOpenedEmail) return;

        playerHasOpenedEmail = false;
        currentEmail = manager.GetRandomEmail();
        isEmailReady = true;
  
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;

        Gizmos.DrawWireSphere(transform.position, detectionRadius);
    }
}
