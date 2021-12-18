using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Xml.Serialization;

namespace AulaCriptografia
{
    public class CriptoAssimetrica
    {

        private static RSACryptoServiceProvider csp = new RSACryptoServiceProvider(2048);
        private RSAParameters privateKey;
        private RSAParameters publicKey;

        public CriptoAssimetrica()
        {
            privateKey = csp.ExportParameters(true);
            publicKey = csp.ExportParameters(false);
        }

        public string getPublicKey()
        {
            var sw = new StringWriter();
            var xs = new XmlSerializer(typeof(RSAParameters));
            xs.Serialize(sw, publicKey);

            return sw.ToString();
        }

        public string encrypt(string text)
        {
            csp = new RSACryptoServiceProvider();
            csp.ImportParameters(publicKey);
            var data = Encoding.Unicode.GetBytes(text);
            var cypher = csp.Encrypt(data, false);
            return Convert.ToBase64String(cypher);
        }

        public string decrypt(string cypherText)
        {
            var dataBytes = Convert.FromBase64String(cypherText);
            csp.ImportParameters(privateKey);
            var text = csp.Decrypt(dataBytes, false);
            return Encoding.Unicode.GetString(text);

        }
    }
}
