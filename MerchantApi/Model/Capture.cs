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
    /// The Refund object
    /// </summary>
    [DataContract]
    public partial class Capture :  IEquatable<Capture>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Refund" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Capture() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Refund" /> class.
        /// </summary>
        /// <param name="RequestId">The id of the refund (required).</param>
        /// <param name="Amount">The refund amount.</param>
        /// <param name="MerchantReference">The merchant's corresponding refund ID or reference.</param>
        /// <param name="RefundId">The unique, Afterpay-generated refund ID.</param>
        /// <param name="RefundedAt">A UTC timestamp of the refund creation time, in ISO 8601 format.</param>
        /// <param name="RefundMerchantReference">A unique reference for the individual refund event. If provided, the value will appear in the daily settlement file as "Payment Event ID".</param>
        public Capture(string RequestId = default(string), string MerchantReference = default(string), Money Amount = default(Money), string RefundMerchantReference = default(string))
        {
            this.RequestId = RequestId;
            this.MerchantReference = MerchantReference;
            this.Amount = Amount;
            this.PaymentEventMerchantReference = PaymentEventMerchantReference;
        }

        /// <summary>
        /// A unique request ID, required (in conjunction with merchantReference) for safe retries
        /// </summary>
        [DataMember(Name= "requestId", EmitDefaultValue=false)]
        public string RequestId { get; set; }
        /// <summary>
        /// The merchant's corresponding refund ID or reference,
        /// </summary>
        [DataMember(Name = "merchantReference", EmitDefaultValue = false)]
        public string MerchantReference { get; set; }
        /// <summary>
        /// The amount that was refunded
        /// </summary>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public Money Amount { get; set; }
        /// <summary>
        /// The unique reference for the individual refund event.
        /// </summary>
        /// <value>The date the refund was created</value>
        [DataMember(Name = "paymentEventMerchantReference", EmitDefaultValue = false)]
        public string PaymentEventMerchantReference { get; set; }

        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Refund {\n");
            sb.Append("  RequestId: ").Append(RequestId).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  MerchantReference: ").Append(MerchantReference).Append("\n");
            sb.Append("  PaymentEventMerchantReference: ").Append(PaymentEventMerchantReference).Append("\n");
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
            return this.Equals(obj as Capture);
        }

        /// <summary>
        /// Returns true if Refund instances are equal
        /// </summary>
        /// <param name="other">Instance of Refund to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Capture other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.RequestId == other.RequestId ||
                    this.RequestId != null &&
                    this.RequestId.Equals(other.RequestId)
                ) && 
                (
                    this.MerchantReference == other.MerchantReference ||
                    this.MerchantReference != null &&
                    this.MerchantReference.Equals(other.MerchantReference)
                ) && 
                (
                    this.Amount == other.Amount ||
                    this.Amount != null &&
                    this.Amount.Equals(other.Amount)
                ) &&
                (
                    this.PaymentEventMerchantReference == other.PaymentEventMerchantReference ||
                    this.PaymentEventMerchantReference != null &&
                    this.PaymentEventMerchantReference.Equals(other.PaymentEventMerchantReference)
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
                if (this.RequestId != null)
                    hash = hash * 59 + this.RequestId.GetHashCode();
                if (this.MerchantReference != null)
                    hash = hash * 59 + this.MerchantReference.GetHashCode();
                if (this.Amount != null)
                    hash = hash * 59 + this.Amount.GetHashCode();
                if (this.PaymentEventMerchantReference != null)
                    hash = hash * 59 + this.PaymentEventMerchantReference.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}