using UnityEngine;
using System.Collections;
using ZXing;

public class Reader : MonoBehaviour
{
    public Texture2D inputTexture; 

    void Start()
    {
        // create a barcode reader instance
        IBarcodeReader reader = new BarcodeReader();
        // get texture Color32 array
        var barcodeBitmap = inputTexture.GetPixels32();
        // detect and decode the barcode inside the Color32 array
        var result = reader.Decode(barcodeBitmap, inputTexture.width, inputTexture.height);
        // do something with the result
        if (result != null)
        {
            Debug.Log(result.BarcodeFormat.ToString());
            Debug.Log(result.Text);

            if (result.Text.Equals("http://gayashan.net"))
            {
                Debug.Log("Wade goda oii!!");
            }
            else
            {
                Debug.Log("hari giye na");
            }
        }
    }
}