using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


    /// <summary>
    /// Made by BahNahNah
    /// HF UID = 2388291
    /// Leave this here.
    /// </summary>
    public static class SimpleCryptography
    {
        #region " Byte Encryption "
        /// <summary>
        /// Encrypt a byte array
        /// </summary>
        /// <param name="payload">The bytes to encrypt</param>
        /// <param name="password">The password to use in the encryption</param>
        /// <param name="salt">an optional secondary password</param>
        /// <returns>Encrypted byte array</returns>
        public static byte[] EncryptBytes(byte[] payload, string password, string salt = "BahNahNah")
        {
            using (PasswordDeriveBytes pwd = new PasswordDeriveBytes(password, Encoding.UTF8.GetBytes(salt)))
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    using (Aes _aes = new AesManaged())
                    {
                        _aes.Key = pwd.GetBytes(_aes.KeySize / 8);
                        _aes.IV = pwd.GetBytes(_aes.BlockSize / 8);
                        using (CryptoStream cs = new CryptoStream(ms, _aes.CreateEncryptor(), CryptoStreamMode.Write))
                        {
                            cs.Write(payload, 0, payload.Length);
                            cs.Close();
                        }
                        return ms.ToArray();
                    }
                }
            }
        }
        /// <summary>
        /// Encrypt a byte array
        /// </summary>
        /// <param name="payload">The bytes to encrypt</param>
        /// <param name="password">The password to use in the encryption</param>
        /// <param name="output">the variable to put the encrypted bytes (will be null on fail)</param>
        /// <param name="salt">an optional secondary password</param>
        /// <returns>The success of the encryption</returns>
        public static bool TryEncryptBytes(byte[] payload, string password, out byte[] output, string salt = "BahNahNah")
        {
            try
            {
                using (PasswordDeriveBytes pwd = new PasswordDeriveBytes(password, Encoding.UTF8.GetBytes(salt)))
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        using (Aes _aes = new AesManaged())
                        {
                            _aes.Key = pwd.GetBytes(_aes.KeySize / 8);
                            _aes.IV = pwd.GetBytes(_aes.BlockSize / 8);
                            using (CryptoStream cs = new CryptoStream(ms, _aes.CreateEncryptor(), CryptoStreamMode.Write))
                            {
                                cs.Write(payload, 0, payload.Length);
                                cs.Close();
                            }
                            output = ms.ToArray();
                        }
                    }
                }
                return true;
            }
            catch
            {
                output = null;
                return false;
            }
        }

        #endregion

        #region " String Encryption "
        /// <summary>
        /// Encrypt a string
        /// </summary>
        /// <param name="input">The string to encrypt</param>
        /// <param name="password">The password to use in the encryption</param>
        /// <param name="salt">an optional secondary password</param>
        /// <returns>The encryoted string</returns>
        public static string EncryptString(string input, string password, string salt = "BahNahNah")
        {
            byte[] StringBytes = System.Text.Encoding.UTF8.GetBytes(input);
            return Convert.ToBase64String(EncryptBytes(StringBytes, password, salt));
        }

        /// <summary>
        /// Encrypt a string
        /// </summary>
        /// <param name="input">The string to encrypt</param>
        /// <param name="password">The password to use in the encryption</param>
        /// <param name="output">the variable to store the encryoted string</param>
        /// <param name="salt">an optional secondary password</param>
        /// <returns>the success of the encryption</returns>
        public static bool TryEncryptString(string input, string password, out string output, string salt = "BahNahNah")
        {
            byte[] StringBytes = System.Text.Encoding.UTF8.GetBytes(input);
            byte[] EncryptedString;
            if (!TryEncryptBytes(StringBytes, password, out EncryptedString, salt))
            {
                output = "";
                return false;
            }
            output = Convert.ToBase64String(EncryptedString);
            return true;
        }

        #endregion

        #region " Byte Decryption "

        /// <summary>
        /// Decrypt a byte array
        /// </summary>
        /// <param name="payload">The bytes to decrypt</param>
        /// <param name="password">The password to use in the decryption</param>
        /// <param name="salt">an optional secondary password</param>
        /// <returns>Decrypted byte array</returns>
        public static byte[] DecryptBytes(byte[] payload, string password, string salt = "BahNahNah")
        {
            using (PasswordDeriveBytes pwd = new PasswordDeriveBytes(password, Encoding.UTF8.GetBytes(salt)))
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    using (Aes _aes = new AesManaged())
                    {
                        _aes.Key = pwd.GetBytes(_aes.KeySize / 8);
                        _aes.IV = pwd.GetBytes(_aes.BlockSize / 8);
                        using (CryptoStream cs = new CryptoStream(ms, _aes.CreateDecryptor(), CryptoStreamMode.Write))
                        {
                            cs.Write(payload, 0, payload.Length);
                            cs.Close();
                        }
                        return ms.ToArray();
                    }
                }
            }
        }

        /// <summary>
        /// Decrypt a byte array
        /// </summary>
        /// <param name="payload">The bytes to decrypt</param>
        /// <param name="password">The password to use in the decryption</param>
        /// <param name="output">the variable to put the decrypted bytes (will be null on fail)</param>
        /// <param name="salt">an optional secondary password</param>
        /// <returns>The success of the deryption</returns>
        public static bool TryDecryptBytes(byte[] payload, string password, out byte[] output, string salt = "BahNahNah")
        {
            try
            {
                using (PasswordDeriveBytes pwd = new PasswordDeriveBytes(password, Encoding.UTF8.GetBytes(salt)))
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        using (Aes _aes = new AesManaged())
                        {
                            _aes.Key = pwd.GetBytes(_aes.KeySize / 8);
                            _aes.IV = pwd.GetBytes(_aes.BlockSize / 8);
                            using (CryptoStream cs = new CryptoStream(ms, _aes.CreateEncryptor(), CryptoStreamMode.Write))
                            {
                                cs.Write(payload, 0, payload.Length);
                                cs.Close();
                            }
                            output = ms.ToArray();
                        }
                    }
                }
                return true;
            }
            catch
            {
                output = null;
                return false;
            }
        }

        #endregion

        #region " String decryption "
        /// <summary>
        /// Decrypt a string
        /// </summary>
        /// <param name="input">The string to decrypt</param>
        /// <param name="password">The password to use in the decryption</param>
        /// <param name="salt">an optional secondary password</param>
        /// <returns>The decrypted string</returns>
        public static string DecryptString(string input, string password, string salt = "BahNahNah")
        {
            return System.Text.Encoding.UTF8.GetString(DecryptBytes(Convert.FromBase64String(input), password, salt));
        }

        /// <summary>
        /// Encrypt a string
        /// </summary>
        /// <param name="input">The string to decrypt</param>
        /// <param name="password">The password to use in the decryption</param>
        /// <param name="output">the variable to store the encryoted string</param>
        /// <param name="salt">an optional secondary password</param>
        /// <returns>the success of the decryption</returns>
        public static bool TryDecryptString(string input, string password, out string output, string salt = "BahNahNah")
        {
            try
            {
                byte[] Decrypted = DecryptBytes(Convert.FromBase64String(input), password, salt);
                output = System.Text.Encoding.UTF8.GetString(Decrypted);
                return true;
            }
            catch
            {
                output = "";
                return false;
            }
        }

        #endregion
    }
