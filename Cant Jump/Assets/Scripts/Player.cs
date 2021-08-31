using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float mvmspd, runspd, curStamina, totalStamina, stmRegen;
    float mvm;

    public Slider slider;
    public Gradient grad;
    public Image img;


    private void Start() {
        curStamina = totalStamina;
        AudioListener.volume = Volume.mastervolume;
    }
    void Update()
    {
        slider.value = curStamina;
        img.color = grad.Evaluate(curStamina);
        mvm = Input.GetAxisRaw("Horizontal");      
    }

    void FixedUpdate()
    {
        if ((Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift)) && curStamina>0 ) {
            if (mvm == 1) { transform.position += new Vector3(1 * Time.fixedDeltaTime * runspd, 0, 0); 
                curStamina -= Time.fixedDeltaTime;
            }
            if (mvm == -1) { transform.position += new Vector3(-1 * Time.fixedDeltaTime * runspd, 0, 0); 
                curStamina -= Time.fixedDeltaTime;
            }
        } else {
            if(curStamina<totalStamina&&!(Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift)))
                curStamina += Time.fixedDeltaTime*stmRegen;
            if (mvm == 1) { transform.position += new Vector3(1 * Time.fixedDeltaTime * mvmspd, 0, 0); }
            if (mvm == -1) { transform.position += new Vector3(-1 * Time.fixedDeltaTime * mvmspd, 0, 0); }
        }        

       
    }

}
