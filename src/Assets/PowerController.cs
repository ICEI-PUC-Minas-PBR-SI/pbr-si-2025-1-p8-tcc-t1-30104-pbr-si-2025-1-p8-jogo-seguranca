using System.Collections;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class PowerController : MonoBehaviour
{
    [SerializeField]
    public int countEnemiesNeededToTrigger = 10;

    [SerializeField]
    public float timeCarNotDestroy = 30f;

    [SerializeField]
    public AudioSource musicPlayer;

    [SerializeField]
    public AudioClip musicClipToPower;

    [SerializeField]
    public AudioClip originalMusicClip;

    [SerializeField]
    public Texture protectedTexture;

    [SerializeField]
    public GameObject uiTextInformation;

    private int countEnemiesDestroyed = 0;

    private Texture originalTexture;
    private Renderer cartRenderer;
    private GameObject cart;
    private HealthSystem cartHealth;
    private Image image;
    private bool powerUsed = false;

    void Start()
    {
        image = GetComponent<Image>();
        cart = GameObject.FindGameObjectWithTag("Cart");

        var pickupTruck = cart.transform.Find("PickupTruck");
        var body = pickupTruck?.transform.Find("Body");

        cartHealth = cart.GetComponent<HealthSystem>();

        if (body != null)
        {
            cartRenderer = body.GetComponent<Renderer>();
            originalTexture = cartRenderer.material.GetTexture("_BaseMap");
        }
    }

    void Update()
    {
        image.fillAmount = ((float)countEnemiesDestroyed / countEnemiesNeededToTrigger);

        if (countEnemiesDestroyed == countEnemiesNeededToTrigger)
        {
            if(!powerUsed)
            {
                uiTextInformation.SetActive(true);
                if (Input.GetKeyDown(KeyCode.R))
                {
                    if (cartHealth != null)
                    {
                        StartCoroutine(EnableDamageAfterDelay());
                    }
                    cartHealth.SetCanDamage(false);
                    uiTextInformation.SetActive(false);
                    powerUsed = true;

                }
            }

        }
    }

    private IEnumerator EnableDamageAfterDelay()
    {
        musicPlayer.clip = musicClipToPower; 
        musicPlayer.Play();

        cartRenderer.material.SetTexture("_BaseMap", protectedTexture);

        yield return new WaitForSeconds(timeCarNotDestroy);

        musicPlayer.clip = originalMusicClip; 
        musicPlayer.Play();

        cartRenderer.material.SetTexture("_BaseMap", originalTexture);

        cartHealth.SetCanDamage(true);
        powerUsed = false;
        countEnemiesDestroyed = 0;
    }

    public void SetEnemyDestroy()
    {
        if (powerUsed)
        {
            return;
        }
        if (countEnemiesDestroyed < countEnemiesNeededToTrigger)
        {
            countEnemiesDestroyed++;
        }
        
    }
}
