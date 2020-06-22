using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace TokenAuthorization.JWT
{
    /// <summary>
    /// JWT encrypt mode
    /// </summary>
    public enum HSMODE
    {
        /// <summary>
        /// Unknown the encrypt mode
        /// </summary>
        Unknown = 0,
        /// <summary>
        /// Encrypt by HMAC SHA1
        /// </summary>
        HS1,
        /// <summary>
        /// Encrypt by HMAC SHA256
        /// </summary>
        HS256,
        /// <summary>
        /// Encrypt by HMAC SHA384
        /// </summary>
        HS384,
        /// <summary>
        /// Encrypt by HMAC SHA512
        /// </summary>
        HS512
    }


    /// <summary>
    /// JWT validation state
    /// </summary>
    public enum VALIDATIONSTATE
    {
        /// <summary>
        /// Validate is OK
        /// </summary>
        Valid = 0,
        /// <summary>
        /// Validate is not OK. eg: JWT format error, one of components can't parse
        /// </summary>
        Invalid,
        /// <summary>
        /// JWT string is foarmatted, but violated. eg: signature is not match, encrypt mode is not match
        /// </summary>
        Violation,
    }


    /// <summary>
    /// Json Web Token autnorization class
    /// Create, parse or validate a JWT by this class
    /// </summary>
    public class JWTAuthentication
    {

        #region The middle varians of propertys

        private bool _isValidated = false;
        private string _secretKey = string.Empty;
        private string _headerRaw = string.Empty;
        private string _headerJson = string.Empty;
        private string _payloadRaw = string.Empty;
        private string _payloadJson = string.Empty;
        private string _signature = string.Empty;
        private HSMODE _mode = HSMODE.Unknown;

        #endregion

        private char[] BASE64_STANDARD_PADDING = { '=' };


        /// <summary>
        /// Indicate the token is validated or not
        /// </summary>
        public bool IsValidated
        {
            get
            {
                return _isValidated;
            }
        }


        /// <summary>
        /// Indicate the token encrypt mode
        /// <para>One of encrypt mode from <see cref="HSMODE"/> as below: <see cref="HSMODE.HS1"/>, <see cref="HSMODE.HS256"/>, <see cref="HSMODE.HS384"/>, <see cref="HSMODE.HS512"/></para>
        /// </summary>
        public HSMODE Mode
        {
            get
            {
                return _mode;
            }
        }


        /// <summary>
        /// Signature part of token
        /// </summary>
        public string Signature
        {
            get
            {
                return _signature;
            }
        }


        /// <summary>
        /// Header part of token in JSON format string
        /// </summary>
        public string HeaderJson
        {
            get
            {
                return _headerJson;
            }
        }


        /// <summary>
        /// Header part of token
        /// </summary>
        public string HeaderRaw
        {
            get
            {
                return _headerRaw;
            }
        }


        /// <summary>
        /// Payload part of token in JSON format string
        /// </summary>
        public string PayloadJson
        {
            get
            {
                return _payloadJson;
            }
        }


        /// <summary>
        /// Payload part of token
        /// </summary>
        public string PayloadRaw
        {
            get
            {
                return _payloadRaw;
            }
        }

        /// <summary>
        /// Secret key of token
        /// </summary>
        public string SecretKey
        {
            get
            {
                return _secretKey;
            }
            set
            {
                _secretKey = value;
            }
        }


        /// <summary>
        /// Create a new <see cref="JWTAuthentication"/> object
        /// </summary>
        public JWTAuthentication()
        {
            // TODO:

        }


        /// <summary>
        /// Create a new <see cref="JWTAuthentication"/> object
        /// </summary>
        /// <param name="key">Secret key of token</param>
        public JWTAuthentication(string key) : this()
        {
            _secretKey = key;
            // TODO:

        }


        /// <summary>
        /// Convert Base64 standard string to Base64Url format string
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        protected string Base64UrlEncode(byte[] data)
        {
            return Convert.ToBase64String(data, Base64FormattingOptions.None).TrimEnd(BASE64_STANDARD_PADDING).Replace('+', '-').Replace('/', '_');
        }



        /// <summary>
        /// Convert Base64Url format string to Base64 standard string
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        protected byte[] Base64UrlDecode(string data)
        {

            string _data = data.Replace('-', '+').Replace('_', '/');
            switch (_data.Length % 4)
            {
                case 0:
                    break;
                case 2:
                    _data += "==";
                    break;
                case 3:
                    _data += "=";
                    break;
                default:
                    return null;
            }

            return Convert.FromBase64String(_data);
        }


        /// <summary>
        /// Create JWT string
        /// </summary>
        /// <param name="Item">Components of payload</param>
        /// <param name="Mode">Encrypt mode, default is <see cref="HSMODE.HS256"/></param>
        /// <returns>JWT string</returns>
        public string CreateToken(object Item, HSMODE Mode = HSMODE.HS256)
        {
            string result = string.Empty;
            string objData, headerData, sigData;
            byte[] buff, keybyte = null;

            JObject joHeader = new JObject();
            HashAlgorithm ha;

            _mode = Mode;
            if (_mode == HSMODE.Unknown) _mode = HSMODE.HS256;

            if (!string.IsNullOrEmpty(_secretKey)) keybyte = Encoding.Default.GetBytes(_secretKey);

            objData = JsonConvert.SerializeObject(Item);
            buff = Encoding.Default.GetBytes(objData);
            _payloadRaw = Base64UrlEncode(buff);

            joHeader.Add("alg", _mode.ToString());
            headerData = joHeader.ToString();
            buff = Encoding.Default.GetBytes(headerData);
            _headerRaw = Base64UrlEncode(buff);

            switch (_mode)
            {
                case HSMODE.HS1:
                    ha = new HMACSHA1(keybyte);
                    break;
                case HSMODE.HS256:
                    ha = new HMACSHA256(keybyte);
                    break;
                case HSMODE.HS384:
                    ha = new HMACSHA384(keybyte);
                    break;
                case HSMODE.HS512:
                    ha = new HMACSHA512(keybyte);
                    break;
                case HSMODE.Unknown:
                    ha = new HMACSHA256(keybyte);
                    break;
                default:
                    ha = new HMACSHA256(keybyte);
                    break;
            }

            sigData = string.Format("{0}.{1}", _headerRaw, _payloadRaw);
            buff = ha.ComputeHash(Encoding.Default.GetBytes(sigData));
            _signature = Base64UrlEncode(buff);

            result = string.Format("{0}.{1}.{2}", _headerRaw, _payloadRaw, _signature);
            return result;
        }


        /// <summary>
        /// Parse the JWT string
        /// </summary>
        /// <typeparam name="T">An object to be parsed from payload component</typeparam>
        /// <param name="Token">JWT string</param>
        /// <returns><typeparamref name="T"/> type object</returns>
        public T ParseToken<T>(string Token)
        {
            T obj = default(T);

            JsonSerializerSettings settings;
            JObject jo;
            HashAlgorithm ha;

            byte[] buff, keybyte = null;
            string[] keys;
            string algName, sigData, sigValid;

            _isValidated = false;
            keys = Token.Split('.');
            if (keys.Length != 3)
            {
                return default(T);
            }

            if (!string.IsNullOrEmpty(_secretKey))
            {
                keybyte = Encoding.Default.GetBytes(_secretKey);
            }

            _headerRaw = keys[0];
            _payloadRaw = keys[1];
            _signature = keys[2];

            settings = new JsonSerializerSettings();
            settings.Formatting = Formatting.Indented;

            _headerJson = JsonConvert.SerializeObject(JsonConvert.DeserializeObject(Encoding.Default.GetString(Base64UrlDecode(_headerRaw))), settings);
            _payloadJson = JsonConvert.SerializeObject(JsonConvert.DeserializeObject(Encoding.Default.GetString(Base64UrlDecode(_payloadRaw))), settings);

            jo = (JObject)JsonConvert.DeserializeObject(_headerJson);
            algName = (string)jo.GetValue("alg");
            Enum.TryParse(algName, out _mode);
            obj = JsonConvert.DeserializeObject<T>(_payloadJson);

            switch (_mode)
            {
                case HSMODE.HS1:
                    ha = new HMACSHA1(keybyte);
                    break;
                case HSMODE.HS256:
                    ha = new HMACSHA256(keybyte);
                    break;
                case HSMODE.HS384:
                    ha = new HMACSHA384(keybyte);
                    break;
                case HSMODE.HS512:
                    ha = new HMACSHA512(keybyte);
                    break;
                case HSMODE.Unknown:
                    ha = new HMACSHA256(keybyte);
                    break;
                default:
                    ha = new HMACSHA256(keybyte);
                    break;
            }

            sigData = string.Format("{0}.{1}", _headerRaw, _payloadRaw);
            buff = ha.ComputeHash(Encoding.Default.GetBytes(sigData));
            sigValid = Base64UrlEncode(buff);

            _isValidated = (sigValid == _signature);
            return obj;
        }


        /// <summary>
        /// Validate the JWT string
        /// </summary>
        /// <param name="Token">JWT string</param>
        /// <returns>One of state from <see cref="VALIDATIONSTATE"/></returns>
        public VALIDATIONSTATE ValidationToken(string Token)
        {
            byte[] keyByte = null, sigByte;
            string[] keys;
            string sigData, algData;

            JsonSerializerSettings settings;
            JObject jo;
            HashAlgorithm ha;

            VALIDATIONSTATE state = VALIDATIONSTATE.Invalid;

            _isValidated = false;
            keys = Token.Split('.');
            if (keys.Length != 3) return state;

            if (!string.IsNullOrEmpty(_secretKey)) keyByte = Encoding.Default.GetBytes(_secretKey);

            _headerRaw = keys[0];
            _payloadRaw = keys[1];
            _signature = keys[2];

            settings = new JsonSerializerSettings();
            settings.Formatting = Formatting.Indented;

            _headerJson = JsonConvert.SerializeObject(JsonConvert.DeserializeObject(Encoding.Default.GetString(Base64UrlDecode(_headerRaw))), settings);
            _payloadJson = JsonConvert.SerializeObject(JsonConvert.DeserializeObject(Encoding.Default.GetString(Base64UrlDecode(_payloadRaw))), settings);

            jo = (JObject)JsonConvert.DeserializeObject(_headerJson);
            algData = (string)jo.GetValue("alg");

            Enum.TryParse(algData, out _mode);
            switch (_mode)
            {
                case HSMODE.HS1:
                    ha = new HMACSHA1(keyByte);
                    break;
                case HSMODE.HS256:
                    ha = new HMACSHA256(keyByte);
                    break;
                case HSMODE.HS384:
                    ha = new HMACSHA384(keyByte);
                    break;
                case HSMODE.HS512:
                    ha = new HMACSHA512(keyByte);
                    break;
                case HSMODE.Unknown:
                    state = VALIDATIONSTATE.Violation;
                    return state;
                default:
                    state = VALIDATIONSTATE.Violation;
                    return state;
            }
            sigByte = ha.ComputeHash(Encoding.Default.GetBytes(string.Format("{0}.{1}", _headerRaw, _payloadRaw)));
            sigData = Base64UrlEncode(sigByte);

            _isValidated = (string.Compare(sigData, _signature) == 0);
            if (_isValidated)
            {
                state = VALIDATIONSTATE.Valid;
            }
            else
            {
                state = VALIDATIONSTATE.Violation;
            }

            return state;
        }
    }
}
