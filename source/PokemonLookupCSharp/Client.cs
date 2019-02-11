//----------------------
// <auto-generated>
//     Generated using the NSwag toolchain v12.0.13.0 (NJsonSchema v9.13.17.0 (Newtonsoft.Json v9.0.0.0)) (http://NSwag.org)
// </auto-generated>
//----------------------

namespace PokemonLookupCSharp
{
    #pragma warning disable

    [System.CodeDom.Compiler.GeneratedCode("NSwag", "12.0.13.0 (NJsonSchema v9.13.17.0 (Newtonsoft.Json v9.0.0.0))")]
    public partial class PokemonLookupAPIClient 
    {
        private string _baseUrl = "";
        private System.Net.Http.HttpClient _httpClient;
        private System.Lazy<Newtonsoft.Json.JsonSerializerSettings> _settings;
    
        public PokemonLookupAPIClient(string baseUrl, System.Net.Http.HttpClient httpClient)
        {
            BaseUrl = baseUrl; 
            _httpClient = httpClient; 
            _settings = new System.Lazy<Newtonsoft.Json.JsonSerializerSettings>(() => 
            {
                var settings = new Newtonsoft.Json.JsonSerializerSettings();
                UpdateJsonSerializerSettings(settings);
                return settings;
            });
        }
    
        public string BaseUrl 
        {
            get { return _baseUrl; }
            set { _baseUrl = value; }
        }
    
        protected Newtonsoft.Json.JsonSerializerSettings JsonSerializerSettings { get { return _settings.Value; } }
    
        partial void UpdateJsonSerializerSettings(Newtonsoft.Json.JsonSerializerSettings settings);
        partial void PrepareRequest(System.Net.Http.HttpClient client, System.Net.Http.HttpRequestMessage request, string url);
        partial void PrepareRequest(System.Net.Http.HttpClient client, System.Net.Http.HttpRequestMessage request, System.Text.StringBuilder urlBuilder);
        partial void ProcessResponse(System.Net.Http.HttpClient client, System.Net.Http.HttpResponseMessage response);
    
        /// <summary>Get all pokemon names.</summary>
        /// <returns>Success</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public System.Threading.Tasks.Task<System.Collections.Generic.ICollection<string>> GetPokemonIndexAsync()
        {
            return GetPokemonIndexAsync(System.Threading.CancellationToken.None);
        }
    
        /// <summary>Get all pokemon names.</summary>
        /// <returns>Success</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        public async System.Threading.Tasks.Task<System.Collections.Generic.ICollection<string>> GetPokemonIndexAsync(System.Threading.CancellationToken cancellationToken)
        {
            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/api/Pokemon");
    
            var client_ = _httpClient;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    request_.Method = new System.Net.Http.HttpMethod("GET");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);
    
                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    try
                    {
                        var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }
    
                        ProcessResponse(client_, response_);
    
                        var status_ = ((int)response_.StatusCode).ToString();
                        if (status_ == "200") 
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false); 
                            var result_ = default(System.Collections.Generic.ICollection<string>); 
                            try
                            {
                                result_ = Newtonsoft.Json.JsonConvert.DeserializeObject<System.Collections.Generic.ICollection<string>>(responseData_, _settings.Value);
                                return result_; 
                            } 
                            catch (System.Exception exception_) 
                            {
                                throw new SwaggerException("Could not deserialize the response body.", (int)response_.StatusCode, responseData_, headers_, exception_);
                            }
                        }
                        else
                        if (status_ != "200" && status_ != "204")
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false); 
                            throw new SwaggerException("The HTTP status code of the response was not expected (" + (int)response_.StatusCode + ").", (int)response_.StatusCode, responseData_, headers_, null);
                        }
            
                        return default(System.Collections.Generic.ICollection<string>);
                    }
                    finally
                    {
                        if (response_ != null)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
            }
        }
    
        /// <summary>Get all pokemon with given type.</summary>
        /// <param name="type">The type name e.g. Fighting</param>
        /// <returns>Success</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Pokemon>> GetPokemonByTypeAsync(string type)
        {
            return GetPokemonByTypeAsync(type, System.Threading.CancellationToken.None);
        }
    
        /// <summary>Get all pokemon with given type.</summary>
        /// <param name="type">The type name e.g. Fighting</param>
        /// <returns>Success</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        public async System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Pokemon>> GetPokemonByTypeAsync(string type, System.Threading.CancellationToken cancellationToken)
        {
            if (type == null)
                throw new System.ArgumentNullException("type");
    
            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/api/Pokemon/ByType/{type}");
            urlBuilder_.Replace("{type}", System.Uri.EscapeDataString(ConvertToString(type, System.Globalization.CultureInfo.InvariantCulture)));
    
            var client_ = _httpClient;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    request_.Method = new System.Net.Http.HttpMethod("GET");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);
    
                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    try
                    {
                        var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }
    
                        ProcessResponse(client_, response_);
    
                        var status_ = ((int)response_.StatusCode).ToString();
                        if (status_ == "404") 
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false); 
                            throw new SwaggerException("Not Found", (int)response_.StatusCode, responseData_, headers_, null);
                        }
                        else
                        if (status_ == "200") 
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false); 
                            var result_ = default(System.Collections.Generic.ICollection<Pokemon>); 
                            try
                            {
                                result_ = Newtonsoft.Json.JsonConvert.DeserializeObject<System.Collections.Generic.ICollection<Pokemon>>(responseData_, _settings.Value);
                                return result_; 
                            } 
                            catch (System.Exception exception_) 
                            {
                                throw new SwaggerException("Could not deserialize the response body.", (int)response_.StatusCode, responseData_, headers_, exception_);
                            }
                        }
                        else
                        if (status_ != "200" && status_ != "204")
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false); 
                            throw new SwaggerException("The HTTP status code of the response was not expected (" + (int)response_.StatusCode + ").", (int)response_.StatusCode, responseData_, headers_, null);
                        }
            
                        return default(System.Collections.Generic.ICollection<Pokemon>);
                    }
                    finally
                    {
                        if (response_ != null)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
            }
        }
    
        /// <summary>Get a pokemon by name.</summary>
        /// <param name="name">The pokemon's name e.g. Pikachu</param>
        /// <returns>Success</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public System.Threading.Tasks.Task<Pokemon> GetSpecificPokemonAsync(string name)
        {
            return GetSpecificPokemonAsync(name, System.Threading.CancellationToken.None);
        }
    
        /// <summary>Get a pokemon by name.</summary>
        /// <param name="name">The pokemon's name e.g. Pikachu</param>
        /// <returns>Success</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        public async System.Threading.Tasks.Task<Pokemon> GetSpecificPokemonAsync(string name, System.Threading.CancellationToken cancellationToken)
        {
            if (name == null)
                throw new System.ArgumentNullException("name");
    
            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/api/Pokemon/{name}");
            urlBuilder_.Replace("{name}", System.Uri.EscapeDataString(ConvertToString(name, System.Globalization.CultureInfo.InvariantCulture)));
    
            var client_ = _httpClient;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    request_.Method = new System.Net.Http.HttpMethod("GET");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);
    
                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    try
                    {
                        var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }
    
                        ProcessResponse(client_, response_);
    
                        var status_ = ((int)response_.StatusCode).ToString();
                        if (status_ == "404") 
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false); 
                            throw new SwaggerException("Not Found", (int)response_.StatusCode, responseData_, headers_, null);
                        }
                        else
                        if (status_ == "200") 
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false); 
                            var result_ = default(Pokemon); 
                            try
                            {
                                result_ = Newtonsoft.Json.JsonConvert.DeserializeObject<Pokemon>(responseData_, _settings.Value);
                                return result_; 
                            } 
                            catch (System.Exception exception_) 
                            {
                                throw new SwaggerException("Could not deserialize the response body.", (int)response_.StatusCode, responseData_, headers_, exception_);
                            }
                        }
                        else
                        if (status_ != "200" && status_ != "204")
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false); 
                            throw new SwaggerException("The HTTP status code of the response was not expected (" + (int)response_.StatusCode + ").", (int)response_.StatusCode, responseData_, headers_, null);
                        }
            
                        return default(Pokemon);
                    }
                    finally
                    {
                        if (response_ != null)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
            }
        }
    
        private string ConvertToString(object value, System.Globalization.CultureInfo cultureInfo)
        {
            if (value is System.Enum)
            {
                string name = System.Enum.GetName(value.GetType(), value);
                if (name != null)
                {
                    var field = System.Reflection.IntrospectionExtensions.GetTypeInfo(value.GetType()).GetDeclaredField(name);
                    if (field != null)
                    {
                        var attribute = System.Reflection.CustomAttributeExtensions.GetCustomAttribute(field, typeof(System.Runtime.Serialization.EnumMemberAttribute)) 
                            as System.Runtime.Serialization.EnumMemberAttribute;
                        if (attribute != null)
                        {
                            return attribute.Value;
                        }
                    }
                }
            }
            else if (value is bool) {
                return System.Convert.ToString(value, cultureInfo).ToLowerInvariant();
            }
            else if (value is byte[])
            {
                return System.Convert.ToBase64String((byte[]) value);
            }
            else if (value != null && value.GetType().IsArray)
            {
                var array = System.Linq.Enumerable.OfType<object>((System.Array) value);
                return string.Join(",", System.Linq.Enumerable.Select(array, o => ConvertToString(o, cultureInfo)));
            }
        
            return System.Convert.ToString(value, cultureInfo);
        }
    }
    
    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.13.17.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class Pokemon 
    {
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? Id { get; set; }
    
        [Newtonsoft.Json.JsonProperty("moves", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Move> Moves { get; set; }
    
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get; set; }
    
        [Newtonsoft.Json.JsonProperty("order", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? Order { get; set; }
    
        [Newtonsoft.Json.JsonProperty("species", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ResourceReference Species { get; set; }
    
        [Newtonsoft.Json.JsonProperty("stats", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Stat> Stats { get; set; }
    
        [Newtonsoft.Json.JsonProperty("types", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<PokemonType> Types { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    
        public static Pokemon FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Pokemon>(data);
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.13.17.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class Move 
    {
        [Newtonsoft.Json.JsonProperty("move", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ResourceReference Move1 { get; set; }
    
        [Newtonsoft.Json.JsonProperty("version_group_details", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<VersionGroupDetail> Version_group_details { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    
        public static Move FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Move>(data);
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.13.17.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class ResourceReference 
    {
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    
        public static ResourceReference FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ResourceReference>(data);
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.13.17.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class Stat 
    {
        [Newtonsoft.Json.JsonProperty("base_stat", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? Base_stat { get; set; }
    
        [Newtonsoft.Json.JsonProperty("effort", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? Effort { get; set; }
    
        [Newtonsoft.Json.JsonProperty("stat", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ResourceReference Stat1 { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    
        public static Stat FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Stat>(data);
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.13.17.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class PokemonType 
    {
        [Newtonsoft.Json.JsonProperty("slot", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? Slot { get; set; }
    
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ResourceReference Type { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    
        public static PokemonType FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<PokemonType>(data);
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.13.17.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class VersionGroupDetail 
    {
        [Newtonsoft.Json.JsonProperty("level_learned_at", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? Level_learned_at { get; set; }
    
        [Newtonsoft.Json.JsonProperty("move_learn_method", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ResourceReference Move_learn_method { get; set; }
    
        [Newtonsoft.Json.JsonProperty("version_group", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ResourceReference Version_group { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    
        public static VersionGroupDetail FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<VersionGroupDetail>(data);
        }
    
    }

    [System.CodeDom.Compiler.GeneratedCode("NSwag", "12.0.13.0 (NJsonSchema v9.13.17.0 (Newtonsoft.Json v9.0.0.0))")]
    public partial class SwaggerException : System.Exception
    {
        public int StatusCode { get; private set; }

        public string Response { get; private set; }

        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.IEnumerable<string>> Headers { get; private set; }

        public SwaggerException(string message, int statusCode, string response, System.Collections.Generic.Dictionary<string, System.Collections.Generic.IEnumerable<string>> headers, System.Exception innerException) 
            : base(message + "\n\nStatus: " + statusCode + "\nResponse: \n" + response.Substring(0, response.Length >= 512 ? 512 : response.Length), innerException)
        {
            StatusCode = statusCode;
            Response = response; 
            Headers = headers;
        }

        public override string ToString()
        {
            return string.Format("HTTP Response: \n\n{0}\n\n{1}", Response, base.ToString());
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("NSwag", "12.0.13.0 (NJsonSchema v9.13.17.0 (Newtonsoft.Json v9.0.0.0))")]
    public partial class SwaggerException<TResult> : SwaggerException
    {
        public TResult Result { get; private set; }

        public SwaggerException(string message, int statusCode, string response, System.Collections.Generic.Dictionary<string, System.Collections.Generic.IEnumerable<string>> headers, TResult result, System.Exception innerException) 
            : base(message, statusCode, response, headers, innerException)
        {
            Result = result;
        }
    }

    #pragma warning restore
}