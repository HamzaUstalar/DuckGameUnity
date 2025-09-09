using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Standartlaşmış,kalıplaşmış 5 adet fonksiyon bulunmaktadır. Çalışma sırasına göre sıralanmıştır.
    void Awake() // Oyun başlamadan default ayarlar diyebiliriz. Mesela score = 0; gibi...
    {
        score = 0;
        Debug.Log("Awake"); // oyuna etkisi yok konsolumuza bir şeyler yazdırmamızı sağlar. Yani biz şuan neyi çalıştırıyoruz sorusunun cevabını verir...

    }
    void Start() // Tam oyun başlarken çalışır ve ikiside birer kere çalışır.
    {
        Debug.Log("Start"); // loglamak yazdırmak gibi düşünelim. print ile aynı işleve sahip yani.
    }
    void Update() // Update,FixedUpdate,LateUpdate gibi fonksiyonlar çok fazla çalıştıkları için içini doldurmamaya çalışacağız.
    {
        Debug.Log("Update");
    }
    void FixedUpdate()
    {
        Debug.Log("FixedUpdate");
    }
    void LateUpdate()
    {
        Debug.Log("LateUpdate");
    }

    int score;
    int number = 5;
    float number2 = 5.5f;
    int number3 = 10;
    string text = "hello";
    bool isTrue = true;

    void TestFunction()
    {
        number = 10;
        number2 = 1.5f;
        text = "Merhaba";
        isTrue = false;
    }
    // int tipindeki fonksiyon bir şey döndürmek zorundadır. Fakat void bir şey döndürmek zorunda değildir.
    int TestFunction2()
    {
        return number + number3;
    }
}
