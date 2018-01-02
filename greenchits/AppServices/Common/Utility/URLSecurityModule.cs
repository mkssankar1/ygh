#region Using

using System;
using System.IO;
using System.Web;
using System.Text;
using System.Security.Cryptography;

#endregion

/// <summary>
/// Summary description for URLSecurityModule
/// </summary>
public class URLSecurityModule : IHttpModule
{

  #region IHttpModule Members
    private const string PARAMETER_NAME = "?enc=";
    private const string ENCRYPTION_KEY = "FLEX12345";
    private const string ConstEnableURLEncryption = "EnableURLEncryption";
    
   public void Init(HttpApplication context)
  {
    context.BeginRequest += new EventHandler(context_BeginRequest);
    context.PostRequestHandlerExecute += new EventHandler(context_EndRequest);
   
  }
 
  void context_BeginRequest(object sender, EventArgs e)
  {
      if (HttpContext.Current.Request.Url.ToString().Contains(PARAMETER_NAME))
      {
          HttpContext.Current.RewritePath(DecryptURLQueryString(HttpContext.Current.Request.Url.ToString()));
      }
  }
  void context_EndRequest(object sender, EventArgs e)
  {
      if (HttpContext.Current.Response.IsRequestBeingRedirected)
      {
          HttpContext.Current.Response.RedirectLocation = EncryptURLQueryString(HttpContext.Current.Response.RedirectLocation);
      }
  }
    /// <summary>
    /// Returns URL with encrypted Query string if exists
    /// </summary>
    /// <param name="strURL"></param>
    /// <returns>url with encrypted Query string</returns>
  public static string EncryptURLQueryString(string strURL)
  {
          if (IsURLEncryptionEnabled())
          {
              if (strURL != null && strURL != String.Empty)
              {
                  if (strURL.Contains("?"))
                  {
                      strURL = strURL.Substring(0, strURL.IndexOf('?')) + Encrypt(strURL.Substring(strURL.IndexOf('?') + 1));
                  }
              }
          }
      return strURL;
  }
    /// <summary>
    /// Returns the Url with unencrypted Query String
    /// </summary>
    /// <param name="strURL"></param>
    /// <returns>string</returns>
  public static string DecryptURLQueryString(string strURL)
  {
      if (strURL != null && strURL != String.Empty)
      {
          if (strURL.Contains(PARAMETER_NAME))
          {
              string path = HttpContext.Current.Request.RawUrl;
              path = path.Substring(0, path.IndexOf(PARAMETER_NAME) + 1);
              strURL = path + Decrypt(strURL.Substring(strURL.IndexOf('=') + 1));
          }
      }
      return strURL;
  }

  public static bool IsURLEncryptionEnabled()
  {   bool blnEncrptionFlag = false;
      if (System.Web.Configuration.WebConfigurationManager.AppSettings[ConstEnableURLEncryption] != null)
      {
         blnEncrptionFlag =Convert.ToBoolean(System.Web.Configuration.WebConfigurationManager.AppSettings[ConstEnableURLEncryption].ToString());
      }
      return blnEncrptionFlag;
  }
  #endregion
  #region Encryption/decryption

  /// <summary>
  /// The salt value used to strengthen the encryption.
  /// </summary>
  private readonly static byte[] SALT = Encoding.ASCII.GetBytes(ENCRYPTION_KEY.Length.ToString());

  /// <summary>
  /// Encrypts any string using the Rijndael algorithm.
  /// </summary>
  /// <param name="inputText">The string to encrypt.</param>
  /// <returns>A Base64 encrypted string.</returns>
  private static string Encrypt(string inputText)
  {
    RijndaelManaged rijndaelCipher = new RijndaelManaged();
    byte[] plainText = Encoding.Unicode.GetBytes(inputText);
    PasswordDeriveBytes SecretKey = new PasswordDeriveBytes(ENCRYPTION_KEY, SALT);

    using (ICryptoTransform encryptor = rijndaelCipher.CreateEncryptor(SecretKey.GetBytes(32), SecretKey.GetBytes(16)))
    {
      using (MemoryStream memoryStream = new MemoryStream())
      {
        using (CryptoStream cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
        {
          cryptoStream.Write(plainText, 0, plainText.Length);
          cryptoStream.FlushFinalBlock();
          return  PARAMETER_NAME + Convert.ToBase64String(memoryStream.ToArray());
        }
      }
    }
  }

  /// <summary>
  /// Decrypts a previously encrypted string.
  /// </summary>
  /// <param name="inputText">The encrypted string to decrypt.</param>
  /// <returns>A decrypted string.</returns>
  private static string Decrypt(string inputText)
  {
    RijndaelManaged rijndaelCipher = new RijndaelManaged();
    byte[] encryptedData = Convert.FromBase64String(inputText);
    PasswordDeriveBytes secretKey = new PasswordDeriveBytes(ENCRYPTION_KEY, SALT);

    using (ICryptoTransform decryptor = rijndaelCipher.CreateDecryptor(secretKey.GetBytes(32), secretKey.GetBytes(16)))
    {
      using (MemoryStream memoryStream = new MemoryStream(encryptedData))
      {
        using (CryptoStream cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read))
        {
          byte[] plainText = new byte[encryptedData.Length];
          int decryptedCount = cryptoStream.Read(plainText, 0, plainText.Length);
          return Encoding.Unicode.GetString(plainText, 0, decryptedCount);
        }
      }
    }
  }
  public void Dispose()
  {
      // Nothing to dispose
  }

  #endregion

}
