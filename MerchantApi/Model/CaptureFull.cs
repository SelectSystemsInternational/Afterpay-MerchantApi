/* 
 * Merchant API
 *
 * Afterpay Merchant API Initial build
 *
 * OpenAPI spec version: 2017-03-01
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace MerchantApi.Model
{
    /// <summary>
    /// The CaptureFull object
    /// </summary>
    [DataContract]
    public partial class CaptureFull :  IEquatable<CaptureFull>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CaptureFull" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CaptureFull() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Refund" /> class.
        /// </summary>
        /// <param name="RequestId">The id of the refund (required).</param>
        /// <param name="Amount">The refund amount.</param>
        /// <param name="MerchantReference">The merchant's corresponding refund ID or reference.</param>
        /// <param name="RefundId">The unique, Afterpay-generated refund ID.</param>
        /// <param name="RefundedAt">A UTC timestamp of the refund creation time, in ISO 8601 format.</param>
        /// <param name="RefundMerchantReference">A unique reference for the individual refund event. If provided, the value will appear in the daily settlement file as "Payment Event ID".</param>
        public CaptureFull(string Token = default(string), string MerchantReference = default(string))
        {
            this.Token = Token;
            this.MerchantReference = MerchantReference;
        }

        /// <summary>
        /// A unique request ID, required (in conjunction with merchantReference) for safe retries
        /// </summary>
        [DataMember(Name= "token", EmitDefaultValue=false)]
        public string Token { get; set; }
        /// <summary>
        /// The merchant's corresponding refund ID or reference,
        /// </summary>
        [DataMember(Name = "merchantReference", EmitDefaultValue = false)]
        public string MerchantReference { get; set; }

        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Refund {\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  MerchantReference: ").Append(MerchantReference).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as CaptureFull);
        }

        /// <summary>
        /// Returns true if Refund instances are equal
        /// </summary>
        /// <param name="other">Instance of Refund to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CaptureFull other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Token == other.Token ||
                    this.Token != null &&
                    this.Token.Equals(other.Token)
                ) && 
                (
                    this.MerchantReference == other.MerchantReference ||
                    this.MerchantReference != null &&
                    this.MerchantReference.Equals(other.MerchantReference)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Token != null)
                    hash = hash * 59 + this.Token.GetHashCode();
                if (this.MerchantReference != null)
                    hash = hash * 59 + this.MerchantReference.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
